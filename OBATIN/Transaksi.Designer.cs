namespace OBATIN
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.no_nota = new System.Windows.Forms.Label();
            this.nama_kasir = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cari_Obat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cariobat = new System.Windows.Forms.ComboBox();
            this.harga_satuan = new System.Windows.Forms.Label();
            this.jumlah_beli = new System.Windows.Forms.Label();
            this.hargasatuan = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tambahbtn = new System.Windows.Forms.Button();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bayar = new System.Windows.Forms.Label();
            this.totalbayar = new System.Windows.Forms.TextBox();
            this.UangTunai = new System.Windows.Forms.Label();
            this.uang_tunai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kembalian = new System.Windows.Forms.TextBox();
            this.simpan = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // no_nota
            // 
            this.no_nota.AutoSize = true;
            this.no_nota.BackColor = System.Drawing.Color.DarkTurquoise;
            this.no_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_nota.Location = new System.Drawing.Point(20, 12);
            this.no_nota.Name = "no_nota";
            this.no_nota.Size = new System.Drawing.Size(66, 16);
            this.no_nota.TabIndex = 0;
            this.no_nota.Text = "No. Nota :";
            // 
            // nama_kasir
            // 
            this.nama_kasir.AutoSize = true;
            this.nama_kasir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.nama_kasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_kasir.Location = new System.Drawing.Point(43, 38);
            this.nama_kasir.Name = "nama_kasir";
            this.nama_kasir.Size = new System.Drawing.Size(43, 16);
            this.nama_kasir.TabIndex = 1;
            this.nama_kasir.Text = "Kasir :";
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.Location = new System.Drawing.Point(288, 12);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(64, 16);
            this.tanggal.TabIndex = 2;
            this.tanggal.Text = "Tanggal :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 67);
            this.panel1.TabIndex = 8;
            // 
            // cari_Obat
            // 
            this.cari_Obat.AutoSize = true;
            this.cari_Obat.BackColor = System.Drawing.Color.Turquoise;
            this.cari_Obat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_Obat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cari_Obat.Location = new System.Drawing.Point(22, 83);
            this.cari_Obat.Name = "cari_Obat";
            this.cari_Obat.Size = new System.Drawing.Size(98, 16);
            this.cari_Obat.TabIndex = 9;
            this.cari_Obat.Text = "Pilih / Cari Obat";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.tambahbtn);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.hargasatuan);
            this.panel2.Controls.Add(this.jumlah_beli);
            this.panel2.Controls.Add(this.harga_satuan);
            this.panel2.Controls.Add(this.cariobat);
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 154);
            this.panel2.TabIndex = 9;
            // 
            // cariobat
            // 
            this.cariobat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cariobat.FormattingEnabled = true;
            this.cariobat.Location = new System.Drawing.Point(134, 3);
            this.cariobat.Name = "cariobat";
            this.cariobat.Size = new System.Drawing.Size(242, 21);
            this.cariobat.TabIndex = 11;
            this.cariobat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // harga_satuan
            // 
            this.harga_satuan.AutoSize = true;
            this.harga_satuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_satuan.Location = new System.Drawing.Point(24, 35);
            this.harga_satuan.Name = "harga_satuan";
            this.harga_satuan.Size = new System.Drawing.Size(99, 16);
            this.harga_satuan.TabIndex = 10;
            this.harga_satuan.Text = "Harga Satuan : ";
            // 
            // jumlah_beli
            // 
            this.jumlah_beli.AutoSize = true;
            this.jumlah_beli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah_beli.Location = new System.Drawing.Point(38, 63);
            this.jumlah_beli.Name = "jumlah_beli";
            this.jumlah_beli.Size = new System.Drawing.Size(82, 16);
            this.jumlah_beli.TabIndex = 12;
            this.jumlah_beli.Text = "Jumlah Beli :";
            // 
            // hargasatuan
            // 
            this.hargasatuan.Location = new System.Drawing.Point(134, 32);
            this.hargasatuan.Name = "hargasatuan";
            this.hargasatuan.ReadOnly = true;
            this.hargasatuan.Size = new System.Drawing.Size(142, 20);
            this.hargasatuan.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 61);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // tambahbtn
            // 
            this.tambahbtn.Location = new System.Drawing.Point(147, 92);
            this.tambahbtn.Name = "tambahbtn";
            this.tambahbtn.Size = new System.Drawing.Size(106, 23);
            this.tambahbtn.TabIndex = 15;
            this.tambahbtn.Text = "+ Tambah Keranjang";
            this.tambahbtn.UseVisualStyleBackColor = true;
            this.tambahbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Location = new System.Drawing.Point(0, 237);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.Size = new System.Drawing.Size(801, 107);
            this.dgvKeranjang.TabIndex = 17;
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.LightGray;
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(686, 312);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(106, 23);
            this.hapus_btn.TabIndex = 16;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.dashboard);
            this.panel3.Controls.Add(this.simpan);
            this.panel3.Controls.Add(this.kembalian);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.uang_tunai);
            this.panel3.Controls.Add(this.UangTunai);
            this.panel3.Controls.Add(this.totalbayar);
            this.panel3.Controls.Add(this.Bayar);
            this.panel3.Location = new System.Drawing.Point(0, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 100);
            this.panel3.TabIndex = 18;
            // 
            // Bayar
            // 
            this.Bayar.AutoSize = true;
            this.Bayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bayar.Location = new System.Drawing.Point(20, 10);
            this.Bayar.Name = "Bayar";
            this.Bayar.Size = new System.Drawing.Size(169, 16);
            this.Bayar.TabIndex = 0;
            this.Bayar.Text = "Total Yang Harus Dibayar :";
            // 
            // totalbayar
            // 
            this.totalbayar.Location = new System.Drawing.Point(195, 9);
            this.totalbayar.Name = "totalbayar";
            this.totalbayar.ReadOnly = true;
            this.totalbayar.Size = new System.Drawing.Size(142, 20);
            this.totalbayar.TabIndex = 16;
            // 
            // UangTunai
            // 
            this.UangTunai.AutoSize = true;
            this.UangTunai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UangTunai.Location = new System.Drawing.Point(22, 44);
            this.UangTunai.Name = "UangTunai";
            this.UangTunai.Size = new System.Drawing.Size(169, 16);
            this.UangTunai.TabIndex = 17;
            this.UangTunai.Text = "Total Yang Harus Dibayar :";
            // 
            // uang_tunai
            // 
            this.uang_tunai.Location = new System.Drawing.Point(195, 44);
            this.uang_tunai.Name = "uang_tunai";
            this.uang_tunai.Size = new System.Drawing.Size(142, 20);
            this.uang_tunai.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Yang Harus Dibayar :";
            // 
            // kembalian
            // 
            this.kembalian.Location = new System.Drawing.Point(195, 67);
            this.kembalian.Name = "kembalian";
            this.kembalian.ReadOnly = true;
            this.kembalian.Size = new System.Drawing.Size(142, 20);
            this.kembalian.TabIndex = 20;
            // 
            // simpan
            // 
            this.simpan.BackColor = System.Drawing.Color.LightGray;
            this.simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.Location = new System.Drawing.Point(473, 27);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(162, 50);
            this.simpan.TabIndex = 19;
            this.simpan.Text = "Simpan dan Cetak Nota";
            this.simpan.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.LightGray;
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(682, 27);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(106, 23);
            this.dashboard.TabIndex = 19;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = false;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.cari_Obat);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.nama_kasir);
            this.Controls.Add(this.no_nota);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label no_nota;
        private System.Windows.Forms.Label nama_kasir;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cari_Obat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cariobat;
        private System.Windows.Forms.Button tambahbtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox hargasatuan;
        private System.Windows.Forms.Label jumlah_beli;
        private System.Windows.Forms.Label harga_satuan;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Bayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uang_tunai;
        private System.Windows.Forms.Label UangTunai;
        private System.Windows.Forms.TextBox totalbayar;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.TextBox kembalian;
        private System.Windows.Forms.Button dashboard;
    }
}