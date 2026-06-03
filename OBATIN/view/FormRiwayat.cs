using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormRiwayat : Form
    {
        private readonly Penjualan_service penjualanService = new Penjualan_service();
        private readonly DateTime tanggalAwal;

        public FormRiwayat()
            : this(DateTime.Now)
        {
        }

        public FormRiwayat(DateTime tanggal)
        {
            tanggalAwal = tanggal;
            InitializeComponent();
            cari_dt.ValueChanged += cari_dt_ValueChanged;
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            riwayat_dgv.AllowUserToAddRows = false;
            riwayat_dgv.ReadOnly = true;
            riwayat_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cari_dt.Value = tanggalAwal;
            MuatRiwayat();
        }

        private void cari_dt_ValueChanged(object sender, EventArgs e)
        {
            MuatRiwayat();
        }

        private void MuatRiwayat()
        {
            try
            {
                riwayat_dgv.DataSource = penjualanService.AmbilRiwayat(cari_dt.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
