using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Napomena
    {
        public string napomenaID { get; set; }
        public string casID { get; set; }
        public string datumNapomena { get; set; }
        public string imeUcenik { get; set; }
        public string opis { get; set; }
        public string prezimeUcenik { get; set; }
        public string ucenikID { get; set; }
    }
}
