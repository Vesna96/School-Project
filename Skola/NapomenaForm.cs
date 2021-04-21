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
    public partial class NapomenaForm : Form
    {
        public int brojac=0;
        public NapomenaForm()
        {
            InitializeComponent();
        }

        private void btnUpisiNapomenu_Click(object sender, EventArgs e)
        {
            brojac++;
        
            string s1 = txtrbrCasa.Text;
            string s2 = txtIdUcenika.Text;
            string s3 = txtImeUcenika.Text;
            string s4 = txtPrezimeUcenika.Text;
            string s5 = txtNapomena.Text;
            string s6 = dtpDatumNapomene.Text;
            string s7 = brojac.ToString();


            DataProvider.DodajNapomenu(s1,s7,s3,s4,s5,s6,s2);

            txtIdUcenika.Clear();
            txtImeUcenika.Clear();
            txtNapomena.Clear();
            txtPrezimeUcenika.Clear();
            txtrbrCasa.Clear();
            dtpDatumNapomene.Refresh();
        }
    }
}
