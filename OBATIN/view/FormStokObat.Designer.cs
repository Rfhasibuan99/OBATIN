namespace OBATIN.view
{
    partial class FormStokObat
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
            this.stok_panel = new System.Windows.Forms.Panel();
            this.obat_dgv = new System.Windows.Forms.DataGridView();
            this.cari_lbl = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.stok_lbl = new System.Windows.Forms.Label();
            this.stok_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // stok_panel
            // 
            this.stok_panel.BackColor = System.Drawing.Color.White;
            this.stok_panel.Controls.Add(this.obat_dgv);
            this.stok_panel.Controls.Add(this.cari_lbl);
            this.stok_panel.Controls.Add(this.cari_txt);
            this.stok_panel.Controls.Add(this.stok_lbl);
            this.stok_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stok_panel.Location = new System.Drawing.Point(0, 0);
            this.stok_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stok_panel.Name = "stok_panel";
            this.stok_panel.Size = new System.Drawing.Size(533, 292);
            this.stok_panel.TabIndex = 0;
            // 
            // obat_dgv
            // 
            this.obat_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.obat_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.obat_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obat_dgv.Location = new System.Drawing.Point(25, 112);
            this.obat_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.obat_dgv.Name = "obat_dgv";
            this.obat_dgv.RowHeadersVisible = false;
            this.obat_dgv.RowHeadersWidth = 62;
            this.obat_dgv.RowTemplate.Height = 28;
            this.obat_dgv.Size = new System.Drawing.Size(491, 172);
            this.obat_dgv.TabIndex = 4;
            // 
            // cari_lbl
            // 
            this.cari_lbl.AutoSize = true;
            this.cari_lbl.Location = new System.Drawing.Point(22, 55);
            this.cari_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cari_lbl.Name = "cari_lbl";
            this.cari_lbl.Size = new System.Drawing.Size(51, 13);
            this.cari_lbl.TabIndex = 3;
            this.cari_lbl.Text = "Cari Obat";
            // 
            // cari_txt
            // 
            this.cari_txt.BackColor = System.Drawing.Color.White;
            this.cari_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cari_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_txt.ForeColor = System.Drawing.Color.Black;
            this.cari_txt.Location = new System.Drawing.Point(24, 72);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(493, 29);
            this.cari_txt.TabIndex = 1;
            // 
            // stok_lbl
            // 
            this.stok_lbl.AutoSize = true;
            this.stok_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok_lbl.ForeColor = System.Drawing.Color.Teal;
            this.stok_lbl.Location = new System.Drawing.Point(201, 20);
            this.stok_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stok_lbl.Name = "stok_lbl";
            this.stok_lbl.Size = new System.Drawing.Size(84, 18);
            this.stok_lbl.TabIndex = 0;
            this.stok_lbl.Text = "Stok Obat";
            // 
            // FormStokObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.stok_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStokObat";
            this.Text = "FormStokObat";
            this.Load += new System.EventHandler(this.FormStokObat_Load);
            this.stok_panel.ResumeLayout(false);
            this.stok_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stok_panel;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Label stok_lbl;
        private System.Windows.Forms.Label cari_lbl;
        private System.Windows.Forms.DataGridView obat_dgv;
    }
}