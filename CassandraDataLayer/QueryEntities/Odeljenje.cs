using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Odeljenje
    {
        public string odeljenjeID { get; set; }
        public string profesorID { get; set; }
        public string razredniIme { get; set; }
        public string razredniPrezime { get; set; }
        public string smerID { get; set; }
    }
}
