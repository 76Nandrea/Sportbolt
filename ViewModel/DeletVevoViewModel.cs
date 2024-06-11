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
    class DeletVevoViewModel
    {
        MySqlConnection conn = new MySqlConnection(Kapcsolat.KapcsolatString);
        Vevo torlendo;

        int id;
        string nev;
        string cim;

        public DeletVevoViewModel(object torlendot)
        {
            this.torlendo = (Vevo)torlendot;
            Id = torlendo.Id;
            Nev = torlendo.Nev;
            Cim = torlendo.Cim;

        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Cim { get => cim; set => cim = value; }

        public void torles()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                MySqlCommand cmdDeletVevo = new MySqlCommand(SQLparancsok.CmdDeletVevo, conn);
                cmdDeletVevo.Parameters.AddWithValue("@id", torlendo.Id);
                cmdDeletVevo.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sikeres törlés!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a vevő törlésénél!");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }
    }
}
