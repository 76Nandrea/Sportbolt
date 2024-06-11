using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportbolt.Adatbázis
{
    class Kapcsolat
    {
        static string kapcsolatString = "Server=localhost; Database = sportbolt; uid=root; password= titok123";

        public static string KapcsolatString { get => kapcsolatString; }
    }
}
