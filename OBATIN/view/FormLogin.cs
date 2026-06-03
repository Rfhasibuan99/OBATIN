using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.konfigurasi; // Memanggil folder lokasi Koneksi.cs kamu
using OBATIN.model;       // Memanggil objek User

namespace OBATIN.view
{
    public partial class FormLogin : Form
    {
        // Instansiasi class koneksi cukup sekali di atas
        private Koneksi kon = new Koneksi();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            password_txt.PasswordChar = '●';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // 1. Validasi input kosong
            if (string.IsNullOrEmpty(usernzme_txt.Text) || string.IsNullOrEmpty(password_txt.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Buat query SQL biasa (karena fungsi eksekusiQuery kamu menerima string query langsung)
                // Kita ambil data input dari textbox
                string query = "SELECT id_user, username, password, role FROM users WHERE " +
                               "username = '" + usernzme_txt.Text + "' AND " +
                               "password = '" + password_txt.Text + "' LIMIT 1";

                // 3. Langsung panggil fungsi eksekusiQuery dari Koneksi.cs
                // Fungsi ini otomatis membuka dan menutup koneksi sendiri di dalamnya
                DataTable dt = kon.eksekusiQuery(query);

                // 4. Cek apakah ada data yang ditemukan (baris tabel lebih dari 0)
                if (dt.Rows.Count > 0)
                {
                    // Mengambil baris pertama (indeks 0) dari hasil data tabel
                    DataRow row = dt.Rows[0];

                    // 5. Masukkan data ke dalam Model User
                    User loggedInUser = new User();
                    loggedInUser.IdUser = Convert.ToInt32(row["id_user"]);
                    loggedInUser.Username = row["username"].ToString();
                    loggedInUser.Role = row["role"].ToString();

                    MessageBox.Show($"Login Berhasil! Selamat datang, Anda masuk sebagai {loggedInUser.Role}.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 6. Pindah ke halaman utama FormAdmin
                    FormAdmin adminPage = new FormAdmin();
                    adminPage.Show();

                    this.Hide(); // Sembunyikan form login
                }
                else
                {
                    // Jika data username dan password tidak cocok di database
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

        }

        private void password_txt_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}