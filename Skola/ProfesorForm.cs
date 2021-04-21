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
    public partial class ProfesorForm : Form
    {
        public string id_profesora;
        public ProfesorForm()
        {
            InitializeComponent();
        }

        public ProfesorForm(string id)
        {
            this.id_profesora = id;
            InitializeComponent();
        }

        private void ProfesorForm_Load(object sender, EventArgs e)
        {
            Profesor profesor = DataProvider.VratiProfesora(id_profesora);
            txtIme.Text = profesor.imeProfesor;
            txtPrezime.Text = profesor.prezimeProfesor;

            List<ProfesorNaPredmetu> pnp = DataProvider.VratiProfesoraNaPredmetu(id_profesora);
            String predajeNaPredmetima = "Predaje na predmetima: ";
            foreach(ProfesorNaPredmetu p in pnp)
            {
                predajeNaPredmetima += p.nazivPredmeta;
                predajeNaPredmetima += " ";
            }
            txtPredajePredmete.Text = predajeNaPredmetima;
            List<ProfesorPredmetOdeljenje> ppo = DataProvider.VratiProfesorPredmetOdeljenje(id_profesora);
            foreach (ProfesorPredmetOdeljenje p in ppo)
            {
                ListViewItem item = new ListViewItem(new string[] { p.odeljenjeId, p.nazivPredmeta });
                listView1.Items.Add(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
