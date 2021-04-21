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
    public partial class UceniciUOdeljenju : Form
    {
        public string odeljenjeID;
        public UceniciUOdeljenju()
        {
            InitializeComponent();
        }

        public UceniciUOdeljenju(string id)
        {
            this.odeljenjeID = id;
            InitializeComponent();
        }

        private void popuniFormu()
        {
            List<Ucenik> ucenici = new List<Ucenik>();
            ucenici = DataProvider.VratiUcenikeIzOdeljenja(odeljenjeID);
            foreach (Ucenik uc in ucenici)
            {
               
                ListViewItem item = new ListViewItem(new string[] { uc.ucenikID,uc.imeUcenik,uc.prezimeUcenik });
                listView1.Items.Add(item);
                

            }

            List<Odeljenje> odeljenja = new List<Odeljenje>();
            odeljenja = DataProvider.VratiOdeljenja();
            foreach (Odeljenje p in odeljenja)
            {
                if(!(p.odeljenjeID).Equals(odeljenjeID))
                cbxOdeljenja.Items.Add(p.odeljenjeID);
            }

            Odeljenje od = new Odeljenje();
            od = DataProvider.VratiOdeljenje(odeljenjeID);
            label5.Text = "Odeljenje: " + od.odeljenjeID;
            label6.Text = "Razredni: " + od.razredniIme + " " + od.razredniPrezime;

            List<Predmet> predmeti = new List<Predmet>();
            predmeti = DataProvider.VratiPredmete();
            foreach (Predmet p in predmeti)
            {
                
                cbxPredmeti.Items.Add(p.predmetID + " " + p.nazivPredmeta);
            }

            List<ProfesorPredmetOdeljenje> pred = new List<ProfesorPredmetOdeljenje>();
            pred = DataProvider.VratiProfesorPredmetZaOdeljenje(odeljenjeID);
            foreach (ProfesorPredmetOdeljenje osp in pred)
            {
                
                ListViewItem item = new ListViewItem(new string[] { osp.predmetID,osp.nazivPredmeta,osp.imeProfesor,osp.prezimeProfesor,osp.profesorID  });
                listView2.Items.Add(item);


            }

            
        }

        private void UceniciUOdeljenju_Load(object sender, EventArgs e)
        {
            this.popuniFormu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            DataProvider.DodajUcenika(id, ime, prezime, odeljenjeID);
            List<OdeljenjeSlusaPredmet> osp = DataProvider.VratiPredmeteZaOdeljenje(odeljenjeID);
            foreach(OdeljenjeSlusaPredmet pred in osp)
            {
                DataProvider.DodajOcenu(pred.predmetID, id, ime, prezime, null, null, null, null, null, null);
            }
            txtId.Clear();
            txtIme.Clear();
            txtPrezime.Clear();

            ListViewItem item = new ListViewItem(new string[] { id,ime,prezime });
            listView1.Items.Add(item);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            string ucenikID = listView1.SelectedItems[0].Text;
            DataProvider.ObrisiIzostankeZaUcenika(ucenikID);
            DataProvider.ObrisiOceneZaUcenika(ucenikID);
            DataProvider.ObrisiUcenika(ucenikID);
            
            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);


        }

        private void btnPremestaj_Click(object sender, EventArgs e)
        {
            string ucenikID = listView1.SelectedItems[0].Text;
            string novoOdeljenje = cbxOdeljenja.SelectedItem.ToString();
            DataProvider.PremestiUcenikaUDrugoOdeljenje(ucenikID, novoOdeljenje);
            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
        }

        private void cbxPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxProfesori.Items.Clear();
            string selektovan = cbxPredmeti.SelectedItem.ToString();
            List<ProfesorNaPredmetu> profesori = new List<ProfesorNaPredmetu>();
            string[] niz = selektovan.Split(' ');
            profesori = DataProvider.VratiProfesoreZaPredmet(niz[0]);
            foreach (ProfesorNaPredmetu p in profesori)
            {
               
                    cbxProfesori.Items.Add(p.profesorID + " " + p.imeProfesor + " " +p.prezimeProfesor);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxPredmeti.SelectedItem != null && cbxProfesori.SelectedItem != null)
            {
                string predmet = cbxPredmeti.SelectedItem.ToString();
                string[] nizP = predmet.Split(' ');
                string profesor = cbxProfesori.SelectedItem.ToString();
                string[] nizProf = profesor.Split(' ');

                DataProvider.DodajPredmetZaOdeljenje(nizP[0], odeljenjeID, nizP[1]);
                DataProvider.DodajProfesoraPredmetOdeljenje(nizProf[0], nizProf[1], nizProf[2], nizP[0], odeljenjeID, nizP[1]);

                ListViewItem item = new ListViewItem(new string[] { nizP[0], nizP[1], nizProf[1], nizProf[2], nizProf[0] });
                listView2.Items.Add(item);
            }
            else
            {
                if (cbxPredmeti.SelectedItem == null)
                {
                    MessageBox.Show("Niste izabrali predmet!");
                }
                if(cbxProfesori.SelectedItem == null)
                {
                    MessageBox.Show("Niste izabrali profesora!");
                }
            }
        }

        private void btnObrisiPredmet_Click(object sender, EventArgs e)
        {
            string predID = listView2.SelectedItems[0].Text;
            string profID = listView2.SelectedItems[0].SubItems[4].Text;
            
            //DataProvider.ObrisiProfesorPredmetOdeljenje(profID, predID, odeljenjeID);
            DataProvider.ObrisiPredmetZaOdeljenje(predID,odeljenjeID);
            ListViewItem item = listView2.SelectedItems[0];
            listView2.Items.Remove(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
