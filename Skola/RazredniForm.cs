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
    public partial class RazredniForm : Form
    {
        public string id_razrednog;
        public RazredniForm()
        {
            InitializeComponent();
        }

        public RazredniForm(string id)
        {
            this.id_razrednog = id;
            InitializeComponent();
        }

        private void btnPrikaziOcene_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte ucenika!");
            }
            else
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                Ucenik ucenik = DataProvider.VratiUcenika(id);
                RazredniOceneForm rf = new RazredniOceneForm(ucenik);
                rf.ShowDialog();
            }
            
        }

        private void btnPrikaziIzostanke_Click(object sender, EventArgs e)
        {
            Odeljenje odeljenje = DataProvider.VratiOdeljenjeProfesor(id_razrednog);
            RazredniIzostanciForm ri = new RazredniIzostanciForm(odeljenje.odeljenjeID);
            ri.ShowDialog();
        }

        private void btnPrikaziNapomene_Click(object sender, EventArgs e)
        {
            Odeljenje odeljenje = DataProvider.VratiOdeljenjeProfesor(id_razrednog);
            RazredniNapomeneForm rn = new RazredniNapomeneForm(odeljenje.odeljenjeID);
            rn.ShowDialog();
        }

        private void RazredniForm_Load(object sender, EventArgs e)
        {
            Odeljenje odeljenje = DataProvider.VratiOdeljenjeProfesor(id_razrednog);
            lblOdeljenje.Text = odeljenje.odeljenjeID;

            this.Popuni_Formu();
        }

        private void Popuni_Formu()
        {
            Odeljenje odeljenje = DataProvider.VratiOdeljenjeProfesor(id_razrednog);
            List<Ucenik> ucenici = DataProvider.VratiUcenikeIzOdeljenja(odeljenje.odeljenjeID);
            foreach (Ucenik ucenik in ucenici)
            {
                ListViewItem item = new ListViewItem(new string[] { ucenik.ucenikID, ucenik.imeUcenik, ucenik.prezimeUcenik });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
    }
}
