using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer.QueryEntities;
using CassandraDataLayer;


namespace Skola
{
    public partial class OdeljenjaNaSmeru : Form
    {
        public string smerID;
        public OdeljenjaNaSmeru()
        {
            InitializeComponent();
        }
        public OdeljenjaNaSmeru(string id)
        {
            this.smerID = id;
            InitializeComponent();
        }
        private void ucitajPodatke()
        {
            List<Odeljenje> odeljenja = new List<Odeljenje>();
            /*odeljenja = DataProvider.VratiOdeljenja();
            foreach (Odeljenje o in odeljenja)
            {
                if ((o.smerID).Equals(smerID))
                {
                    ListViewItem item = new ListViewItem(new string[] { o.odeljenjeID, o.smerID, o.razredniIme, o.razredniPrezime });
                    listView1.Items.Add(item);
                }

            }*/
            odeljenja = DataProvider.VratiOdeljenjaSaSmera(smerID);
            foreach (Odeljenje o in odeljenja)
            {
                List<Ucenik> ucenici = new List<Ucenik>();
                ucenici = DataProvider.VratiUcenikeIzOdeljenja(o.odeljenjeID);
                ListViewItem item = new ListViewItem(new string[] { o.odeljenjeID, o.smerID, o.razredniIme, o.razredniPrezime,
                    ucenici.Count.ToString() });
                listView1.Items.Add(item);
                

            }

            
        }
        private void OdeljenjaNaSmeru_Load(object sender, EventArgs e)
        {
            this.ucitajPodatke();

            List<Profesor> profesori = new List<Profesor>();
            profesori = DataProvider.VratiProfesore();
            foreach (Profesor p in profesori)
            {
                cbxProfesor.Items.Add(p.profesorID+ " " +p.imeProfesor + " "+ p.prezimeProfesor);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string razred = txtRazred.Text;
            string selektovan = cbxProfesor.SelectedItem.ToString();
            string[] niz = selektovan.Split(' ');
            DataProvider.DodajOdeljenje(razred,smerID,niz[0],niz[1],niz[2]);
            //DodajOdeljenje dodOd = new DodajOdeljenje();
            //dodOd.Show();
            
            ListViewItem item = new ListViewItem(new string[] { razred, smerID,niz[1],niz[2] });
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            txtRazred.Text = listView1.SelectedItems[0].Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string razred = txtRazred.Text;
            string selektovan = cbxProfesor.SelectedItem.ToString();
            string[] niz = selektovan.Split(' ');
            DataProvider.PromeniRazrednog(razred, niz[0], niz[1], niz[2],smerID);

            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
            ListViewItem itemNov = new ListViewItem(new string[] { razred, smerID,niz[1],niz[2] });
            listView1.Items.Add(itemNov);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string razred = txtRazred.Text;
            DataProvider.ObrisiOdeljenje(razred);
            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string odeljenjeID = listView1.SelectedItems[0].Text;
            UceniciUOdeljenju uuo = new UceniciUOdeljenju(odeljenjeID);
            uuo.Show();
        }
    }
}
