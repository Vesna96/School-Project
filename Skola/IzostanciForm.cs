using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;

namespace Skola
{
    public partial class IzostanciForm : Form
    {
        public int brojac = 0;
        public string id_odeljenja;
        public string id_casa;
        public IzostanciForm()
        {
            InitializeComponent();
        }

       public IzostanciForm(string idOd,string idCas)
        {
            this.id_odeljenja = idOd;
            this.id_casa = idCas;
            InitializeComponent();
        }

        private void btnUpisiteIzostanke_Click(object sender, EventArgs e)
        {
            
           
            string s2 = txtImeUcenika1.Text;
            string s3 = txtPrezimeUcenika1.Text;
            
            string s5 = txtRbrUcenika.Text;
            string s7 = dtmDatumIzostanaka.Text;
            string izostanak = "Jos uvek nije opravdan";


            DataProvider.DodajIzostanak(id_casa,s7,s2,id_odeljenja,s3,izostanak,s5);

           
            txtImeUcenika1.Clear();
            txtPrezimeUcenika1.Clear();
            
            txtRbrUcenika.Clear();
            dtmDatumIzostanaka.Refresh();
        }

        private void IzostanciForm_Load(object sender, EventArgs e)
        {

        }
    }
}
