using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBATIN.view
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            transaksi_btn.Click += transaksi_btn_Click;
            riwayat_btn.Click += riwayat_btn_Click;
            kelolastok_btn.Click += kelolastok_btn_Click;
            menuuser_btn.Click += menuuser_btn_Click;
            logout_btn.Click += logout_btn_Click;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void transaksi_btn_Click(object sender, EventArgs e)
        {

        }

        private void transaksi_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void transaksi_btn_Click(object sender, EventArgs e)
        {
            FormTransaksi form = new FormTransaksi();
            form.Show();
        }

        private void riwayat_btn_Click(object sender, EventArgs e)
        {
            FormRiwayat form = new FormRiwayat();
            form.Show();
        }

        private void kelolastok_btn_Click(object sender, EventArgs e)
        {
            FormStokObat form = new FormStokObat();
            form.Show();
        }

        private void menuuser_btn_Click(object sender, EventArgs e)
        {
            FormObat form = new FormObat();
            form.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            Close();
        }
    }
}
