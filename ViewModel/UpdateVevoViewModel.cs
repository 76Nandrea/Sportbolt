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
    class UpdateVevoViewModel
    {
        MySqlConnection conn = new MySqlConnection(Kapcsolat.KapcsolatString);
        Vevo modositando;

        int id;
        string nev;
        string cim;



        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Cim { get => cim; set => cim = value; }


        public UpdateVevoViewModel(object vevo)
        {
            modositando = (Vevo)vevo;
            id = modositando.Id;
            nev = modositando.Nev;
            cim = modositando.Cim;
        }

        public void modosit(string nev, string cim)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                MySqlCommand cmdUpdateVevo = new MySqlCommand(SQLparancsok.CmdUpdateVevo, conn);
                cmdUpdateVevo.Parameters.AddWithValue("@id", modositando.Id);
                cmdUpdateVevo.Parameters.AddWithValue("@nev", Nev);
                cmdUpdateVevo.Parameters.AddWithValue("@cim", Cim);
                cmdUpdateVevo.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sikeres módosítás!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a vevő módosításánál!");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }

        }
    }
}

