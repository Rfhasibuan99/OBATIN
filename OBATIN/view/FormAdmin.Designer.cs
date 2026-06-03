namespace OBATIN.view
{
    partial class FormAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.riwayat_btn = new System.Windows.Forms.Button();
            this.kelolastok_btn = new System.Windows.Forms.Button();
            this.transaksi_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.judul_lbl = new System.Windows.Forms.Label();
            this.transaksi_panel = new System.Windows.Forms.Panel();
            this.transaksi_lbl = new System.Windows.Forms.Label();
            this.stokobat_panel = new System.Windows.Forms.Panel();
            this.stok_lbl = new System.Windows.Forms.Label();
            this.expired_panel = new System.Windows.Forms.Panel();
            this.expired_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.transaksi_panel.SuspendLayout();
            this.stokobat_panel.SuspendLayout();
            this.expired_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.riwayat_btn);
            this.panel1.Controls.Add(this.kelolastok_btn);
            this.panel1.Controls.Add(this.transaksi_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 366);
            this.panel1.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.DarkRed;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(8, 329);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(133, 29);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            // 
            // riwayat_btn
            // 
            this.riwayat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.riwayat_btn.ForeColor = System.Drawing.Color.Black;
            this.riwayat_btn.Location = new System.Drawing.Point(10, 273);
            this.riwayat_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.riwayat_btn.Name = "riwayat_btn";
            this.riwayat_btn.Size = new System.Drawing.Size(127, 29);
            this.riwayat_btn.TabIndex = 4;
            this.riwayat_btn.Text = "Riwayat /LogStok";
            this.riwayat_btn.UseVisualStyleBackColor = true;
            // 
            // kelolastok_btn
            // 
            this.kelolastok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kelolastok_btn.ForeColor = System.Drawing.Color.Black;
            this.kelolastok_btn.Location = new System.Drawing.Point(10, 216);
            this.kelolastok_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kelolastok_btn.Name = "kelolastok_btn";
            this.kelolastok_btn.Size = new System.Drawing.Size(127, 29);
            this.kelolastok_btn.TabIndex = 3;
            this.kelolastok_btn.Text = "Kelola Stok Obat";
            this.kelolastok_btn.UseVisualStyleBackColor = true;
            // 
            // transaksi_btn
            // 
            this.transaksi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaksi_btn.ForeColor = System.Drawing.Color.Black;
            this.transaksi_btn.Location = new System.Drawing.Point(10, 160);
            this.transaksi_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transaksi_btn.Name = "transaksi_btn";
            this.transaksi_btn.Size = new System.Drawing.Size(127, 29);
            this.transaksi_btn.TabIndex = 2;
            this.transaksi_btn.Text = "Transaksi Baru";
            this.transaksi_btn.UseVisualStyleBackColor = true;
            this.transaksi_btn.Click += new System.EventHandler(this.transaksi_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.Black;
            this.dashboard_btn.Location = new System.Drawing.Point(10, 102);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(127, 29);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OBATIN.Properties.Resources.obatin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.judul_lbl);
            this.panel2.Location = new System.Drawing.Point(146, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 65);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelola data obat dengan mudah";
            // 
            // judul_lbl
            // 
            this.judul_lbl.AutoSize = true;
            this.judul_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_lbl.ForeColor = System.Drawing.Color.Teal;
            this.judul_lbl.Location = new System.Drawing.Point(17, 16);
            this.judul_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.judul_lbl.Name = "judul_lbl";
            this.judul_lbl.Size = new System.Drawing.Size(221, 24);
            this.judul_lbl.TabIndex = 0;
            this.judul_lbl.Text = "Selamat Datang Admin";
            // 
            // transaksi_panel
            // 
            this.transaksi_panel.BackColor = System.Drawing.Color.CadetBlue;
            this.transaksi_panel.Controls.Add(this.transaksi_lbl);
            this.transaksi_panel.Location = new System.Drawing.Point(167, 110);
            this.transaksi_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transaksi_panel.Name = "transaksi_panel";
            this.transaksi_panel.Size = new System.Drawing.Size(104, 83);
            this.transaksi_panel.TabIndex = 2;
            this.transaksi_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.transaksi_panel_Paint);
            // 
            // transaksi_lbl
            // 
            this.transaksi_lbl.AutoSize = true;
            this.transaksi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaksi_lbl.ForeColor = System.Drawing.Color.White;
            this.transaksi_lbl.Location = new System.Drawing.Point(3, 13);
            this.transaksi_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.transaksi_lbl.Name = "transaksi_lbl";
            this.transaksi_lbl.Size = new System.Drawing.Size(107, 13);
            this.transaksi_lbl.TabIndex = 0;
            this.transaksi_lbl.Text = "Transaksi Hari Ini";
            // 
            // stokobat_panel
            // 
            this.stokobat_panel.BackColor = System.Drawing.Color.CadetBlue;
            this.stokobat_panel.Controls.Add(this.stok_lbl);
            this.stokobat_panel.Location = new System.Drawing.Point(445, 110);
            this.stokobat_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stokobat_panel.Name = "stokobat_panel";
            this.stokobat_panel.Size = new System.Drawing.Size(104, 83);
            this.stokobat_panel.TabIndex = 3;
            // 
            // stok_lbl
            // 
            this.stok_lbl.AutoSize = true;
            this.stok_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok_lbl.ForeColor = System.Drawing.Color.White;
            this.stok_lbl.Location = new System.Drawing.Point(21, 13);
            this.stok_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stok_lbl.Name = "stok_lbl";
            this.stok_lbl.Size = new System.Drawing.Size(68, 13);
            this.stok_lbl.TabIndex = 0;
            this.stok_lbl.Text = "Stok Obat ";
            // 
            // expired_panel
            // 
            this.expired_panel.BackColor = System.Drawing.Color.CadetBlue;
            this.expired_panel.Controls.Add(this.expired_lbl);
            this.expired_panel.Location = new System.Drawing.Point(302, 110);
            this.expired_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expired_panel.Name = "expired_panel";
            this.expired_panel.Size = new System.Drawing.Size(111, 83);
            this.expired_panel.TabIndex = 4;
            // 
            // expired_lbl
            // 
            this.expired_lbl.AutoSize = true;
            this.expired_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expired_lbl.ForeColor = System.Drawing.Color.White;
            this.expired_lbl.Location = new System.Drawing.Point(31, 13);
            this.expired_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expired_lbl.Name = "expired_lbl";
            this.expired_lbl.Size = new System.Drawing.Size(49, 13);
            this.expired_lbl.TabIndex = 0;
            this.expired_lbl.Text = "Expired";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 366);
            this.Controls.Add(this.expired_panel);
            this.Controls.Add(this.stokobat_panel);
            this.Controls.Add(this.transaksi_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.transaksi_panel.ResumeLayout(false);
            this.transaksi_panel.PerformLayout();
            this.stokobat_panel.ResumeLayout(false);
            this.stokobat_panel.PerformLayout();
            this.expired_panel.ResumeLayout(false);
            this.expired_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button riwayat_btn;
        private System.Windows.Forms.Button kelolastok_btn;
        private System.Windows.Forms.Button transaksi_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label judul_lbl;
        private System.Windows.Forms.Panel transaksi_panel;
        private System.Windows.Forms.Label transaksi_lbl;
        private System.Windows.Forms.Panel stokobat_panel;
        private System.Windows.Forms.Label stok_lbl;
        private System.Windows.Forms.Panel expired_panel;
        private System.Windows.Forms.Label expired_lbl;
    }
}