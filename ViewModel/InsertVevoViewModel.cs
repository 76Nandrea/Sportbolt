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
    class InsertVevoViewModel
    {
        MySqlConnection conn = new MySqlConnection(Kapcsolat.KapcsolatString);
      

        public InsertVevoViewModel(string nev, string cim)
        {
            Vevo ujvevo = new Vevo(-1, nev, cim);

            try
            {
                if(conn.State == System.Data.ConnectionState.Closed) conn.Open();
                MySqlCommand cmdInsertVevo = new MySqlCommand(SQLparancsok.CmdInsertVevo, conn);
                cmdInsertVevo.Parameters.AddWithValue("@nev", ujvevo.Nev);
                cmdInsertVevo.Parameters.AddWithValue("@cim", ujvevo.Cim);
                cmdInsertVevo.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sikeres mentés!");
                }
            catch (Exception)
            {
                MessageBox.Show("Hiba az új vevő beszúrásánál!");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }
    }
}
