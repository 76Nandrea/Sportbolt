using MySql.Data.MySqlClient;
using Sportbolt.Adatbázis;
using Sportbolt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sportbolt.ViewModel
{
    class VevoTablaViewModel
    {
        MySqlConnection conn = new MySqlConnection(Kapcsolat.KapcsolatString);

     
        List<Vevo> vevok = new List<Vevo>();

        public VevoTablaViewModel()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                MySqlCommand cmdVevok = new MySqlCommand(SQLparancsok.CmdVevok, conn);
                MySqlDataReader dr = cmdVevok.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string n = dr.GetString(1);
                    string c = dr.GetString(2);
                    Vevo ujvevo = new Vevo(id, n, c);
                    Vevok.Add(ujvevo);
                }
                conn.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Hiba a vevők lekérdezésénél!");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }

        internal List<Vevo> Vevok { get => vevok; set => vevok = value; }
    }
}
