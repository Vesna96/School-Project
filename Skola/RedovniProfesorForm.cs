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

    public partial class RedovniProfesorForm : Form
    {
        public int brojac = 0;
        public string prvi;
        public string drugi;
        public string id_prof;

        public RedovniProfesorForm()
        {

            InitializeComponent();
        }

        public RedovniProfesorForm(string id)
        {
            this.id_prof = id;
            InitializeComponent();
        }

        private void cmbxRedProfPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxOdSlusaPredmet.Items.Clear();
            string predmet = cmbxRedProfPredmeti.SelectedItem.ToString();
            string[] niz = predmet.Split(' ');
            string id_predmeta = cmbxRedProfPredmeti.SelectedItem.ToString();
            List<ProfesorPredmetOdeljenje> odSlusaPredmet = new List<ProfesorPredmetOdeljenje>();
            odSlusaPredmet = DataProvider.VratiOdeljenjeZaPredmetProfesor(id_prof, niz[0]);
            foreach (ProfesorPredmetOdeljenje pnp in odSlusaPredmet)
            {

                cmbxOdSlusaPredmet.Items.Add(pnp.odeljenjeId);

            }
            cmbxOdSlusaPredmet.Text = "Odaberite odeljenje kojem predajete";
        }

        private void RedovniProfesorForm_Load(object sender, EventArgs e)
        {
            List<ProfesorNaPredmetu> predmetiProfesora = new List<ProfesorNaPredmetu>();
            List<ProfesorNaPredmetu> profNaPred = new List<ProfesorNaPredmetu>();
            profNaPred = DataProvider.VratiPredmeteZaProfesora();

            //filtriramo predmete koje predaje profesor sa prosledjenim id-jem
            foreach(ProfesorNaPredmetu pnp in profNaPred)
            {
                if (pnp.profesorID == id_prof)
                    predmetiProfesora.Add(pnp);
            }
     
            foreach (ProfesorNaPredmetu pnp in profNaPred)
            {
                if(pnp.profesorID == id_prof)
                {
                    cmbxRedProfPredmeti.Items.Add(pnp.predmetID + " " +pnp.nazivPredmeta);
                }
            }

                   
            /*List<ProfesorNaPredmetu> profPred = new List<ProfesorNaPredmetu>();
            profPred = DataProvider.VratiPredmeteZaProfesora();*/

            /*foreach (ProfesorNaPredmetu pnp in predmetiProfesora)
            {
                foreach (OdeljenjeSlusaPredmet osp in odSlusaPredmet)
                    if (pnp.predmetID == osp.predmetID)
                    {
                        cmbxOdSlusaPredmet.Items.Add(osp.odeljenjeID);
                    }
            }*/


            //eliminisanje duplikata iz combobox-a
            List<object> list = new List<object>();
            foreach (object o in cmbxOdSlusaPredmet.Items)
            {
                if (!list.Contains(o))
                {
                    list.Add(o);
                }
            }
            cmbxOdSlusaPredmet.Items.Clear();
            cmbxOdSlusaPredmet.Items.AddRange(list.ToArray());
            //this.Popuni_Formu1();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            popuni();
            /*brojac++;

            if (brojac == 1)
            {
                popuni();
            }
            else if(brojac > 1)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                  
                        listView1.Items[i].Remove();
                        i--;
                }
                
                popuni();
            }*/

        }

        private void popuni()
        {


            /*if (cmbxRedProfPredmeti.SelectedItem == null)
            {
                MessageBox.Show("Odaberite predmet!");
            }

            if (cmbxOdSlusaPredmet.SelectedItem == null)
            {
                MessageBox.Show("Odaberite odeljenje!");
            }*/
            listView1.Items.Clear();
            string predmet = cmbxRedProfPredmeti.SelectedItem.ToString();
            string[] niz = predmet.Split(' ');
            
            string odeljenje = cmbxOdSlusaPredmet.SelectedItem.ToString();
            List<Ucenik> ucenici = DataProvider.VratiUcenikeIzOdeljenja(odeljenje);
            foreach(Ucenik uc in ucenici)
            {
                Ocene oc = DataProvider.VratiOcenu(niz[0], uc.ucenikID);
                ListViewItem itemp = new ListViewItem(new string[] { uc.ucenikID,uc.imeUcenik,uc.prezimeUcenik,
                    oc.test1,oc.test2,oc.test3,oc.test4,oc.prosek,oc.zakljucnaOcena});
                listView1.Items.Add(itemp);
            }

            //string id_predmeta = cmbxRedProfPredmeti.SelectedItem.ToString();
            
            /*List<Ocene> ocene = DataProvider.VratiOceneZaOdeljenjeIPredmet(niz[0],odeljenje);
            foreach (Ocene oc in ocene)
            {
                ListViewItem itemp = new ListViewItem(new string[] { oc.ucenikID,oc.imeUcenik,oc.prezimeUcenik,
                    oc.test1,oc.test2,oc.test3,oc.test4,oc.prosek,oc.zakljucnaOcena});
                listView1.Items.Add(itemp);
            }*/


            /*List<OdeljenjeSlusaPredmet> od1 = DataProvider.VratiOdeljenjaKojaSlusajuPredmete();
            prvi = cmbxRedProfPredmeti.SelectedItem.ToString();
            drugi = cmbxOdSlusaPredmet.SelectedItem.ToString();


            List<Ucenik> ucenici = DataProvider.VratiUcenike();
            List<Ucenik> uceniciOdeljenja = new List<Ucenik>();
            string id;
            foreach (OdeljenjeSlusaPredmet o in od1)
            {
                if ((o.nazivPredmeta == prvi) && (o.razred == drugi))
                {
                    //ListViewItem item = new ListViewItem(new string[] { o.odeljenjeSlusaPredmetID, o.nazivPredmeta, o.odeljenjeID, o.predmetID, o.razred });
                    //listView1.Items.Add(item);
                    id = o.odeljenjeID;
                    foreach (Ucenik u in ucenici)
                    {
                        if (u.odeljenjeID == id)
                        {
                            uceniciOdeljenja.Add(u);
                        }
                    }
                }
            }

            foreach (Ucenik u in uceniciOdeljenja)
            {
                ListViewItem item = new ListViewItem(new string[] { u.ucenikID, u.imeUcenik, u.odeljenjeID, u.prezimeUcenik });
                listView1.Items.Add(item);
            }

     

            listView1.Refresh();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id_odeljenja = cmbxOdSlusaPredmet.Text;
            DodajCasForm form = new DodajCasForm(id_odeljenja,id_prof);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string id_ucenika = listView1.SelectedItems[0].Text;
                string ime = listView1.SelectedItems[0].SubItems[1].Text;
                string prezime = listView1.SelectedItems[0].SubItems[2].Text;
                string predmet = cmbxRedProfPredmeti.Text;
                string[] niz = predmet.Split(' ');
                string id_odeljenja = cmbxOdSlusaPredmet.Text;
                UcenikNovoForm form = new UcenikNovoForm(id_ucenika,niz[0],id_odeljenja,ime,prezime);
                form.Show();
                return;
            }
            else
            {
                MessageBox.Show("Selektujte ucenika!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxOdSlusaPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuni();
        }
    }
}

