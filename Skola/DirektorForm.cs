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
    public partial class DirektorForm : Form
    {
        public string id_direktora;
        //public Direktor Direktor { get; set; }

        public DirektorForm()
        {
            InitializeComponent();
        }

        public DirektorForm(string id)
        {
            this.id_direktora = id;
            InitializeComponent();
        }

        private void btnDodajSmer_Click(object sender, EventArgs e)
        {
            SmeroviForm form = new SmeroviForm();
            form.ShowDialog();
        }

        private void DirektorForm_Load(object sender, EventArgs e)
        {
            Direktor d = DataProvider.GetDirektor(id_direktora);
            lblImeD.Text = d.imeDirektor;
            lblPrezime.Text = d.prezimeDirektor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajNoviPredmet_Click(object sender, EventArgs e)
        {
            Predmeti forma = new Predmeti();
            forma.ShowDialog();
        }

        private void btnDodajProfesora_Click(object sender, EventArgs e)
        {
            DodajProfesora pf = new DodajProfesora();
            pf.ShowDialog();
        }
    }
}
