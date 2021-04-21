using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class ProfesorNaPredmetu
    {
        public string profesorNaPredmetuID { get; set; }
        public string predmetID { get; set; }
        public string profesorID { get; set; }
        public string imeProfesor { get; set; }
        public string prezimeProfesor { get; set; }
        public string nazivPredmeta { get; set; }
    }
}
