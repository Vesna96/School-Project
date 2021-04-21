using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Cas
    {
        public string casID { get; set; }
        public string datumCas { get; set; }
        public string opisCas { get; set; }
        public string profesorID { get; set; }
        public string imeProfesor { get; set; }
        public string prezimeProfesor { get; set; }
        public string napomena { get; set; }
        public string odeljenjeID { get; set; }
    }
}
