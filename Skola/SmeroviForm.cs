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
    public partial class SmeroviForm : Form
    {
        public SmeroviForm()
        {
            InitializeComponent();
        }

        private void ucitajFormu()
        {
            /*List<Smer> smerovi = new List<Smer>();
            smerovi = DataProvider.VratiSmerove();

            foreach (Smer s in smerovi)
            {

                cmbxSmerovi.Items.Add(s.nazivSmera);
            }*/
            
            List<Smer> smerovi = new List<Smer>();
            smerovi = DataProvider.VratiSmerove();
            foreach(Smer s in smerovi)
            {
                List<Odeljenje> odeljenja = new List<Odeljenje>();
                odeljenja = DataProvider.VratiOdeljenjaSaSmera(s.smerID);
                int broj = odeljenja.Count();
                string brOd = broj.ToString();
                ListViewItem item = new ListViewItem(new string[] { s.smerID, s.nazivSmera,brOd });
                listView1.Items.Add(item);
            }


        }

        private void SmeroviForm_Load(object sender, EventArgs e)
        {

            this.ucitajFormu();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string sifra = txtSifra.Text;
            string naziv = txtNaziv.Text;
            List<Smer> smerovi = new List<Smer>();
            smerovi = DataProvider.VratiSmerove();
            foreach(Smer s in smerovi)
            {
                if ((s.smerID).Equals(sifra))
                    MessageBox.Show("Vec postoji smer sa tom sifrom. Uneti novu sifru!");
            }
            DataProvider.DodajSmer(sifra, naziv);
            txtSifra.Clear();
            txtNaziv.Clear();

            ListViewItem item = new ListViewItem(new string[] { sifra, naziv });
            listView1.Items.Add(item);

        }

        private void cmbxSmerovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*List<Odeljenje> odeljenja = new List<Odeljenje>();
            odeljenja = DataProvider.VratiOdeljenja();
            string izabranSmerID = cmbxSmerovi.SelectedText;
            foreach(Odeljenje od in odeljenja)
            {
                if()
                ListViewItem item = new ListViewItem(new string[] { od.odeljenjeID, p.nazivPredmeta });
                listView1.Items.Add(item);
            }*/
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string sifraSmera = listView1.SelectedItems[0].Text;
            OdeljenjaNaSmeru ons = new OdeljenjaNaSmeru(sifraSmera);
            ons.Show();
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            string id = txtSifra.Text;
            string naziv = txtNaziv.Text;
            DataProvider.AzurirajSmer(id, naziv);

            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
            ListViewItem itemNov = new ListViewItem(new string[] { id, naziv });
            listView1.Items.Add(itemNov);

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            txtSifra.Text = listView1.SelectedItems[0].Text;
        }
    }
}
