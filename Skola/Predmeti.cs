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
    public partial class Predmeti : Form
    {
        public Predmeti()
        {
            InitializeComponent();
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            string sifra = txtSifraPredmeta.Text;
            string naziv = txtNazivPredmeta.Text;
            DataProvider.DodajPredmet(sifra,naziv);
            listView1.Items.Add(new ListViewItem(new string[] {sifra , naziv }));
            
        }

        private void Predmeti_Load(object sender, EventArgs e)
        {
            this.Popuni_Formu();
        }
        private void Popuni_Formu()
        {
            List<Predmet> predmeti = DataProvider.VratiPredmete();
            foreach (Predmet p in predmeti)
            {
                ListViewItem item = new ListViewItem(new string[] { p.predmetID, p.nazivPredmeta });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                String sifra = item.Text;
                DataProvider.ObrisiPredmet(sifra);
                listView1.Items.Remove(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            txtSifraPredmeta.Text = listView1.SelectedItems[0].Text;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string novNaziv = txtNazivPredmeta.Text;
            string id = listView1.SelectedItems[0].Text;
            DataProvider.AzurirajPredmet(id,novNaziv);

            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
            ListViewItem itemNov = new ListViewItem(new string[] {id, novNaziv });
            listView1.Items.Add(itemNov);

            txtNazivPredmeta.Clear();
            txtSifraPredmeta.Clear();

        }
    }
}
