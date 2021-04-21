using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class OdeljenjeSlusaPredmet
    {
        public string odeljenjeSlusaPredmetID { get; set; }
        public string predmetID { get; set; }
        public string odeljenjeID { get; set; }
        public string razred { get; set; }
        public string nazivPredmeta { get; set; }
    }
}
