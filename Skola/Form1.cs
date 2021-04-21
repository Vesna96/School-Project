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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLogIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            string id = txtBoxLogIn.Text;

            if (id == "")
            {
                MessageBox.Show("Uneti sifru!");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    if (proveraDirektor(id))
                    {
                        DirektorForm form = new DirektorForm(id);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Uneli ste pogresan ID!");
                        txtBoxLogIn.Clear();
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (proveraProfesor(id))
                    {
                        ProfesorFormInterfejs form = new ProfesorFormInterfejs(id);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Uneli ste pogresan ID!");
                        txtBoxLogIn.Clear();
                    }

                }
                else if (radioButton3.Checked)
                {
                    if (proveraUcenik(id))
                    {
                        UcenikForm form = new UcenikForm(id);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Uneli ste pogresan ID!");
                        txtBoxLogIn.Clear();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool proveraDirektor(string id)
        {
            Direktor d = new Direktor();
            d = DataProvider.VratiDirektora();
            if ((d.direktorID).Equals(id))
                return true;
            return false;
        }
        private bool proveraProfesor(string id)
        {
            List<Profesor> profesori = new List<Profesor>();
            profesori = DataProvider.VratiProfesore();
            foreach (Profesor prof in profesori)
            {
                if (prof.profesorID == id)
                    return true;
            }
            return false;
        }
        private bool proveraUcenik(string id)
        {
            List<Ucenik> ucenici = new List<Ucenik>();
            ucenici = DataProvider.VratiUcenike();
            foreach (Ucenik ucen in ucenici)
            {
                if (ucen.ucenikID == id)
                    return true;
            }
            return false;
        }
    }
}
