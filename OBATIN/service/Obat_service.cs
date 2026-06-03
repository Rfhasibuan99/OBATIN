using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OBATIN.konfigurasi;
using OBATIN.model;

namespace OBATIN.service
{
    internal class Obat_service
    {
        private readonly Koneksi kon = new Koneksi();

        public List<Obat> AmbilObatTersedia()
        {
            DataTable dt = kon.eksekusiQuery("SELECT id_obat, nama_obat, harga, stok FROM obat WHERE stok > 0 ORDER BY nama_obat");
            List<Obat> daftar = new List<Obat>();

            foreach (DataRow row in dt.Rows)
            {
                daftar.Add(new Obat
                {
                    IdObat = Convert.ToInt32(row["id_obat"]),
                    NamaObat = row["nama_obat"].ToString(),
                    Harga = Convert.ToDecimal(row["harga"]),
                    Stok = Convert.ToInt32(row["stok"])
                });
            }

            return daftar;
        }
    }
}
