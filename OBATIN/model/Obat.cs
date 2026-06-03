using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBATIN.model
{
    internal class Obat
    {
        public int IdObat { get; set; }
        public string NamaObat { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }

        public override string ToString()
        {
            return NamaObat;
        }
    }
}
