using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using OBATIN.konfigurasi;
using OBATIN.model;

namespace OBATIN.service
{
    internal class Penjualan_service
    {
        private const string Link = "server=localhost;port=3306;database=obatin;uid=root;pwd=";
        private readonly Koneksi kon = new Koneksi();

        public string BuatNoNota()
        {
            string prefix = "NT" + DateTime.Now.ToString("yyyyMMdd");
            string query = "SELECT no_nota FROM penjualan WHERE no_nota LIKE '" + prefix + "%' ORDER BY no_nota DESC LIMIT 1";
            DataTable dt = kon.eksekusiQuery(query);

            if (dt.Rows.Count == 0)
            {
                return prefix + "001";
            }

            string terakhir = dt.Rows[0]["no_nota"].ToString();
            int nomor = Convert.ToInt32(terakhir.Substring(prefix.Length)) + 1;
            return prefix + nomor.ToString("D3");
        }

        public bool Simpan(Penjualan penjualan)
        {
            using (MySqlConnection con = new MySqlConnection(Link))
            {
                con.Open();
                using (MySqlTransaction trx = con.BeginTransaction())
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(
                            "INSERT INTO penjualan (no_nota, tanggal, kasir, total_bayar) VALUES (@no_nota, @tanggal, @kasir, @total_bayar)",
                            con,
                            trx);
                        cmd.Parameters.AddWithValue("@no_nota", penjualan.NoNota);
                        cmd.Parameters.AddWithValue("@tanggal", penjualan.Tanggal);
                        cmd.Parameters.AddWithValue("@kasir", penjualan.Kasir);
                        cmd.Parameters.AddWithValue("@total_bayar", penjualan.TotalBayar);
                        cmd.ExecuteNonQuery();

                        int idPenjualan = Convert.ToInt32(cmd.LastInsertedId);

                        foreach (DetailPenjualan detail in penjualan.Detail)
                        {
                            MySqlCommand detailCmd = new MySqlCommand(
                                "INSERT INTO detail_penjualan (id_penjualan, id_obat, nama_obat, harga, jumlah, subtotal) VALUES (@id_penjualan, @id_obat, @nama_obat, @harga, @jumlah, @subtotal)",
                                con,
                                trx);
                            detailCmd.Parameters.AddWithValue("@id_penjualan", idPenjualan);
                            detailCmd.Parameters.AddWithValue("@id_obat", detail.IdObat);
                            detailCmd.Parameters.AddWithValue("@nama_obat", detail.NamaObat);
                            detailCmd.Parameters.AddWithValue("@harga", detail.Harga);
                            detailCmd.Parameters.AddWithValue("@jumlah", detail.Jumlah);
                            detailCmd.Parameters.AddWithValue("@subtotal", detail.Subtotal);
                            detailCmd.ExecuteNonQuery();

                            MySqlCommand stokCmd = new MySqlCommand(
                                "UPDATE obat SET stok = stok - @jumlah WHERE id_obat = @id_obat AND stok >= @jumlah",
                                con,
                                trx);
                            stokCmd.Parameters.AddWithValue("@jumlah", detail.Jumlah);
                            stokCmd.Parameters.AddWithValue("@id_obat", detail.IdObat);

                            if (stokCmd.ExecuteNonQuery() == 0)
                            {
                                throw new InvalidOperationException("Stok " + detail.NamaObat + " tidak mencukupi.");
                            }
                        }

                        trx.Commit();
                        return true;
                    }
                    catch
                    {
                        trx.Rollback();
                        throw;
                    }
                }
            }
        }

        public DataTable AmbilRiwayat(DateTime tanggal)
        {
            string tgl = tanggal.ToString("yyyy-MM-dd");
            string query = "SELECT p.no_nota AS 'No Nota', DATE_FORMAT(p.tanggal, '%d/%m/%Y') AS 'Tanggal', " +
                           "p.kasir AS 'Kasir', d.nama_obat AS 'Nama Obat', d.harga AS 'Harga', " +
                           "d.jumlah AS 'Jumlah', d.subtotal AS 'Subtotal', p.total_bayar AS 'Total Bayar' " +
                           "FROM penjualan p INNER JOIN detail_penjualan d ON p.id_penjualan = d.id_penjualan " +
                           "WHERE DATE(p.tanggal) = '" + tgl + "' ORDER BY p.tanggal DESC, p.no_nota DESC";
            return kon.eksekusiQuery(query);
        }
    }
}
