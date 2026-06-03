using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBATIN.model
{
    internal class Penjualan
    {
        public int IdPenjualan { get; set; }
        public string NoNota { get; set; }
        public string Kasir { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal TotalBayar { get; set; }
        public List<DetailPenjualan> Detail { get; set; }

        public Penjualan()
        {
            Detail = new List<DetailPenjualan>();
        }
    }
}
