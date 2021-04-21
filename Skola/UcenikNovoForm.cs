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
    public partial class UcenikNovoForm : Form
    {
        public string ocena;
        public string id_ucenika;
        public string id_predmeta;
        public string id_odeljenja;
        public string ime_ucenik;
        public string prezime_ucenik;

        public UcenikNovoForm()
        {
            InitializeComponent();
        }

        public UcenikNovoForm(string id_uc,string id_pr,string id_od,string ime, string prezime)
        {
            this.id_ucenika = id_uc;
            this.id_predmeta = id_pr;
            this.id_odeljenja = id_od;
            this.ime_ucenik = ime;
            this.prezime_ucenik = prezime;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.izracunajZakljucnuOcenu();
            
            //DataProvider.AzurirajOcene(id_predmeta, id_ucenika, test1, test2, test3, test4,prosek,zakljucnaOcena);
        }

        private void izracunajZakljucnuOcenu()
        {
            int zakljucnaOcena;

            string s1 = numTest1.Text;
            string s2 = numTest2.Text;
            string s3 = numTest3.Text;
            string s4 = numTest4.Text;

            int t1 = Int32.Parse(numTest1.Text);
            int t2 = Int32.Parse(numTest2.Text);
            int t3 = Int32.Parse(numTest3.Text);
            int t4 = Int32.Parse(numTest4.Text);

            double brojac = 4;
            if (t1 == 0)
            {
                s1 = null;
                brojac--;
            }
     
            if (t2 == 0)
            {
                s2 = null;
                brojac--;
            }
            if (t3 == 0)
            {
                s3 = null;
                brojac--;
            }
            if (t4 == 0)
            {
                s4 = null;
                brojac--;
            }

            double prosek = (t1 + t2 + t3 + t4) / brojac;
            string pr = prosek.ToString();


            if (brojac >= 3)
            {
                if (prosek >= 4.5 && prosek <= 5.0)
                {
                    zakljucnaOcena = 5;
                    ocena = zakljucnaOcena.ToString();
                }
                else if (prosek >= 3.5 && prosek < 4.5)
                {
                    zakljucnaOcena = 4;
                    ocena = zakljucnaOcena.ToString();
                }
                else if (prosek >= 2.5 && prosek < 3.5)
                {
                    zakljucnaOcena = 3;
                    ocena = zakljucnaOcena.ToString();
                }
                else if (prosek >= 1.5 && prosek < 2.5)
                {
                    zakljucnaOcena = 2;
                    ocena = zakljucnaOcena.ToString();
                }
                else
                {
                    zakljucnaOcena = 1;
                    ocena = zakljucnaOcena.ToString();
                }
            }

            //DataProvider.DodajOcenu(s1, s2, s3, s4, pr, ocena);
            
            DataProvider.AzurirajOcene(id_predmeta, id_ucenika,ime_ucenik,prezime_ucenik ,s1, s2, s3, s4, pr, ocena);
        }

        private void UcenikNovoForm_Load(object sender, EventArgs e)
        {
            Ocene oc = DataProvider.VratiOcenu(id_predmeta, id_ucenika);
            if(oc.test1 != String.Empty)
            {
                numTest1.Text = oc.test1;
                numTest1.Enabled = false;
                //txtTest1.Text = oc.test1;
                //txtTest1.Enabled = false;
            }
            if (oc.test2 != String.Empty)
            {
                numTest2.Text = oc.test2;
                numTest2.Enabled = false;
                //txtTest2.Text = oc.test2;
                //txtTest2.Enabled = false;
            }
            if (oc.test3 != String.Empty)
            {
                numTest3.Text = oc.test3;
                numTest3.Enabled = false;
                //txtTest3.Text = oc.test3;
                //txtTest3.Enabled = false;
            }
            if (oc.test4 != String.Empty)
            {
                numTest4.Text = oc.test4;
                numTest4.Enabled = false;
                //txtTest4.Text = oc.test4;
                //txtTest4.Enabled = false;
            }
        }
    }
}
