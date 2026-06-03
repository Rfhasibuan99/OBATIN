using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBATIN.model
{
    internal class DetailPenjualan
    {
        public int IdDetail { get; set; }
        public int IdPenjualan { get; set; }
        public int IdObat { get; set; }
        public string NamaObat { get; set; }
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }
        public decimal Subtotal { get; set; }
    }
}
