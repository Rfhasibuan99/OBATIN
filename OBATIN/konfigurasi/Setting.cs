using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sirembaa.konfigurasi
{
    internal class Setting
    {
        public static string[] ambilSeting(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
