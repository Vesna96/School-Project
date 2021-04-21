using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Izostanak
    {
        public string izostanakID { get; set; }
        public string casID { get; set; }
        public string odeljenjeID { get; set; }
        public string datumIzostanak { get; set; }
        public string imeUcenik { get; set; }
        public string prezimeUcenik { get; set; }
        public string tip { get; set; }
        public string ucenikID { get; set; }
    }
}
