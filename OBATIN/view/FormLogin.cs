using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.konfigurasi; // Lokasi kelas Koneksi kamu
using OBATIN.model;       // Lokasi model User kamu

namespace OBATIN.view
{
    public partial class FormLogin : Form
    {
        // Instansiasi class koneksi cukup sekali di atas
        private Koneksi kon = new Koneksi();

        public FormLogin()
        {
            InitializeComponent();

            // Meniru temanmu: Membuat aplikasi langsung fullscreen dan posisi panel tetap di tengah
            this.WindowState = FormWindowState.Maximized;
            CenterPanel();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Mengubah karakter password saat diketik
            password_txt.PasswordChar = '●';
        }

        // Fungsi dari temanmu agar posisi form login tetap presisi di tengah layar
        private void CenterPanel()
        {
            // Pastikan 'panelkiri' atau container login kamu disesuaikan namanya di sini jika berbeda
            // Jika kamu membungkus semua textbox ke dalam satu panel khusus, ganti 'panelkiri' dengan nama panel tersebut.
            // Jika tidak menggunakan panel pelindung, fungsi ini bisa kamu hapus.
            /*
            login_panel.Left = (this.ClientSize.Width - login_panel.Width) / 2;
            login_panel.Top = (this.ClientSize.Height - login_panel.Height) / 2;
            */
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // 1. Validasi input kosong
            if (string.IsNullOrEmpty(k.Text) || string.IsNullOrEmpty(password_txt.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Menyusun query pencocokan data ke MySQL database obatin
                string query = "SELECT id_user, username, password, role FROM users WHERE " +
                               "username = '" + k.Text + "' AND " +
                               "password = '" + password_txt.Text + "' LIMIT 1";

                // 3. Eksekusi query lewat servis koneksi bawaan kamu
                DataTable dt = kon.eksekusiQuery(query);

                // 4. Cek apakah baris data ditemukan
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // 5. Set data ke dalam Model OOP User (Gaya kamu)
                    User loggedInUser = new User();
                    loggedInUser.IdUser = Convert.ToInt32(row["id_user"]);
                    loggedInUser.Username = row["username"].ToString();
                    loggedInUser.Role = row["role"].ToString();

                    // --- OPSIONAL: JIKA KAMU MEMILIKI KELAS 'Session' SEPERTI TEMANMU ---
                    // Kamu bisa aktifkan baris di bawah ini jika sudah membuat kelas global Session.cs
                    /*
                    Session.id_user = loggedInUser.IdUser;
                    Session.username = loggedInUser.Username;
                    Session.role = loggedInUser.Role;
                    */

                    MessageBox.Show($"Login Berhasil! Selamat datang, Anda masuk sebagai {loggedInUser.Role}.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 6. Pindah langsung ke FormTransaksi
                    FormTransaksi transaksiPage = new FormTransaksi(loggedInUser.Username);
                    transaksiPage.FormClosed += (s, args) => this.Close();
                    transaksiPage.Show();

                    this.Hide(); // Sembunyikan form login
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi masalah pada sistem login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernzme_txt_TextChanged_1(object sender, EventArgs e)
        {
            // Tempat event teks berubah
        }

        private void password_txt_TextChanged_1(object sender, EventArgs e)
        {
            // Tempat event teks berubah
        }

        private void password_txt_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
