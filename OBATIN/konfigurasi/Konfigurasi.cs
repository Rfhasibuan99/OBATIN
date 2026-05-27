using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBATIN.konfigurasi
{
    abstract class Konfigurasi
    {
        //untuk menangani  instruksi INSERT UPDATE dan DELETE
        public abstract int eksekusiNonQuery(string query);

        //untuk menangani instruksi SELECT
        public abstract DataTable eksekusiQuery(string query);

    }
}
