using MySql.Data.MySqlClient;
using OBATIN.konfigurasi;
using OBATIN.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBATIN.konfigurasi
{
    internal class Koneksi : Konfigurasi
    {
        MySqlConnection _con;
        MySqlCommand _com;
        MySqlDataAdapter _adapter;
        string _Link = "server=localhost;port=3306;database=obatin;uid=root;pwd=";

        //string _Link = data[0] + ";" + data[1] + ";" + data[2] + ";" + data[3] + ";" + data[4];
        public Koneksi()
        {
            _con = new MySqlConnection(_Link);
            _com = new MySqlCommand();
            _adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (_con.State == ConnectionState.Closed)
                {
                    _con.Open();
                }
            }
            catch (Exception ex) { }
        }
        void tutupKoneksi()
        {
            _con.Close();
        }


        public override int eksekusiNonQuery(string query)
        {
            int nilai = -1;
            try
            {
                bukaKoneksi();
                _com.Connection = _con;
                _com.CommandText = query;
                nilai = _com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }
            return nilai;
        }

        public override DataTable eksekusiQuery(string query)
        {

            DataTable nilai = new DataTable();
            try
            {
                bukaKoneksi();
                _com.Connection = _con;
                _com.CommandText = query;
                _adapter.SelectCommand = _com;
                _adapter.Fill(nilai);
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }
            return nilai;
        }
    }
}
