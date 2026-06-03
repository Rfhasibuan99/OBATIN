using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using OBATIN.model;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormTransaksi : Form
    {
        private readonly Obat_service obatService = new Obat_service();
        private readonly Penjualan_service penjualanService = new Penjualan_service();
        private readonly List<DetailPenjualan> keranjang = new List<DetailPenjualan>();
        private readonly string namaKasir;
        private decimal totalBayar = 0;

        public FormTransaksi()
            : this("Admin")
        {
        }

        public FormTransaksi(string namaKasir)
        {
            this.namaKasir = string.IsNullOrWhiteSpace(namaKasir) ? "Admin" : namaKasir;
            InitializeComponent();
            tambah_btn.Click += tambah_btn_Click;
            simpannota_btn.Click += simpannota_btn_Click;
            dashboard_btn.Click += dashboard_btn_Click;
            obat_cb.SelectedIndexChanged += obat_cb_SelectedIndexChanged;
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            SiapkanGrid();
            ResetForm();
            MuatObat();
        }

        private void SiapkanGrid()
        {
            transaksi_dgv.AllowUserToAddRows = false;
            transaksi_dgv.ReadOnly = true;
            transaksi_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            NamaObat.Visible = true;
            Harga.Visible = true;
            Jumlah.Visible = true;
            Subtotal.Visible = true;
        }

        private void MuatObat()
        {
            List<Obat> daftarObat = obatService.AmbilObatTersedia();
            obat_cb.DataSource = daftarObat;
            obat_cb.DisplayMember = "NamaObat";
            obat_cb.ValueMember = "IdObat";

            if (daftarObat.Count == 0)
            {
                harga_txt.Clear();
                tambah_btn.Enabled = false;
                MessageBox.Show("Data obat belum tersedia atau stok kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tambah_btn.Enabled = true;
            TampilkanHargaObat();
        }

        private void ResetForm()
        {
            keranjang.Clear();
            transaksi_dgv.Rows.Clear();
            totalBayar = 0;
            byr_lbl.Text = FormatRupiah(totalBayar);
            nota_txt.Text = penjualanService.BuatNoNota();
            kasir_txt.Text = namaKasir;
            dateTimePicker1.Value = DateTime.Now;
            jumlah_num.Value = 1;
        }

        private void obat_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanHargaObat();
        }

        private void TampilkanHargaObat()
        {
            Obat obat = obat_cb.SelectedItem as Obat;
            harga_txt.Text = obat == null ? "" : FormatRupiah(obat.Harga);
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            Obat obat = obat_cb.SelectedItem as Obat;
            if (obat == null)
            {
                MessageBox.Show("Pilih obat terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jumlah = Convert.ToInt32(jumlah_num.Value);
            int jumlahDalamKeranjang = keranjang.Where(x => x.IdObat == obat.IdObat).Sum(x => x.Jumlah);
            if (jumlahDalamKeranjang + jumlah > obat.Stok)
            {
                MessageBox.Show("Jumlah beli melebihi stok tersedia. Stok saat ini: " + obat.Stok, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetailPenjualan item = keranjang.FirstOrDefault(x => x.IdObat == obat.IdObat);
            if (item == null)
            {
                item = new DetailPenjualan
                {
                    IdObat = obat.IdObat,
                    NamaObat = obat.NamaObat,
                    Harga = obat.Harga
                };
                keranjang.Add(item);
            }

            item.Jumlah += jumlah;
            item.Subtotal = item.Harga * item.Jumlah;
            TampilkanKeranjang();
        }

        private void TampilkanKeranjang()
        {
            transaksi_dgv.Rows.Clear();
            totalBayar = 0;

            foreach (DetailPenjualan item in keranjang)
            {
                transaksi_dgv.Rows.Add(item.NamaObat, FormatRupiah(item.Harga), item.Jumlah, FormatRupiah(item.Subtotal));
                totalBayar += item.Subtotal;
            }

            byr_lbl.Text = FormatRupiah(totalBayar);
        }

        private void simpannota_btn_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Penjualan penjualan = new Penjualan
                {
                    NoNota = nota_txt.Text,
                    Kasir = kasir_txt.Text,
                    Tanggal = dateTimePicker1.Value,
                    TotalBayar = totalBayar,
                    Detail = keranjang.Select(x => new DetailPenjualan
                    {
                        IdObat = x.IdObat,
                        NamaObat = x.NamaObat,
                        Harga = x.Harga,
                        Jumlah = x.Jumlah,
                        Subtotal = x.Subtotal
                    }).ToList()
                };

                penjualanService.Simpan(penjualan);
                MessageBox.Show("Nota berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormRiwayat riwayat = new FormRiwayat(dateTimePicker1.Value);
                riwayat.Show();
                ResetForm();
                MuatObat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan nota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
            Close();
        }

        private string FormatRupiah(decimal nilai)
        {
            return string.Format(new CultureInfo("id-ID"), "Rp {0:N0}", nilai);
        }
    }
}
