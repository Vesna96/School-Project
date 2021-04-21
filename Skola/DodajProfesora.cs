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
    public partial class DodajProfesora : Form
    {
        public DodajProfesora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            
            DataProvider.DodajProfesora(id, ime, prezime);
            listView2.Items.Add(new ListViewItem (new string[] { id, ime, prezime }));
            txtId.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
        }

        private void ucitajPodatke()
        {
            List<Predmet> predmeti = new List<Predmet>();
            predmeti = DataProvider.VratiPredmete();
            foreach (Predmet p in predmeti)
            {
               
                cmbxPredmeti.Items.Add(p.predmetID + " " +  p.nazivPredmeta );
            }

            List<Profesor> profesori = new List<Profesor>();
            profesori = DataProvider.VratiProfesore();
            foreach(Profesor pro in profesori)
            {
                ListViewItem itemp = new ListViewItem(new string[] {pro.profesorID, pro.imeProfesor, pro.prezimeProfesor });
                listView2.Items.Add(itemp);
            }


        }

        private void DodajProfesora_Load(object sender, EventArgs e)
        {
            this.ucitajPodatke();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void obrisiProfesora_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                String sifra = item.Text;
                DataProvider.ObrisiProfesoraPredmetOdeljenje(sifra);
                DataProvider.ObrisiProfesoraSaPredmeta(sifra);
                //DataProvider.ObrisiProfesorNaPredmetu(sifra);
                DataProvider.ObrisiProfesora(sifra);
                
                listView2.Items.Remove(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbxPredmeti.SelectedItem == null)
                MessageBox.Show("Izaberite predmet na kome radi selektovani profesor");

            if (cmbxPredmeti.SelectedItem != null)
            {
                if (listView2.SelectedItems.Count == 0)
                    MessageBox.Show("Niste izabrali profesora iz liste");
                else
                {
                    ListViewItem item = listView2.SelectedItems[0];
                    string profID = item.Text;

                    
                    string[] sifraNaziv = cmbxPredmeti.SelectedItem.ToString().Split(' ');
                    String predID = sifraNaziv[0];
                    Profesor prof = DataProvider.VratiProfesora(profID);
                    Predmet pred = DataProvider.VratiPredmet(predID);
                    DataProvider.DodajProfesoraNaPredmetu(profID, prof.imeProfesor, prof.prezimeProfesor, predID, pred.nazivPredmeta);
                    MessageBox.Show("Profesor " + prof.imeProfesor + " " + prof.prezimeProfesor +
                        " predaje na predmetu " + pred.nazivPredmeta);
                    
                }

            }
        }

        private void btnPrikaziProfesora_Click(object sender, EventArgs e)
        {
            

            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte profesora za koga zelite da vidite podatke");
            }
            else
            {
                String profesorId = listView2.SelectedItems[0].Text;
                ProfesorForm pf = new ProfesorForm(profesorId);
                pf.ShowDialog();
            }
            
        }
    }
}
