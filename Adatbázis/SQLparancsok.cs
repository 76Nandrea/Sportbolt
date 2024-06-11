using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportbolt.Adatbázis
{
    class SQLparancsok
    {
        static string cmdVevok = "SELECT * FROM sportbolt.vásárló;";
        static string cmdInsertVevo = "INSERT INTO sportbolt.vásárló (nev, cim) VALUES (@nev, @cim);";
        //static string cmdInsertVevoOpc = "INSERT INTO sportbolt.vásárló VALUES (null, @név, @cím);";
        static string cmdDeletVevo = "DELETE FROM sportbolt.vásárló WHERE (id = @id);";
        static string cmdUpdateVevo = "UPDATE sportbolt.vásárló SET nev=@nev,cim=@cim WHERE id =@id;";


        public static string CmdVevok { get => cmdVevok;  }
        public static string CmdInsertVevo { get => cmdInsertVevo; }
        public static string CmdDeletVevo { get => cmdDeletVevo; }
        public static string CmdUpdateVevo { get => cmdUpdateVevo; }
    }
}
