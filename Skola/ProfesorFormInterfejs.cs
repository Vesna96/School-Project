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
    public partial class ProfesorFormInterfejs : Form
    {
        public string id_profesora;
        public ProfesorFormInterfejs()
        {
            InitializeComponent();
        }

        public ProfesorFormInterfejs(string id)
        {
            this.id_profesora = id;
            InitializeComponent();
        }


        private void ProfesorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (radioButton1.Checked)
                {
                    RedovniProfesorForm form = new RedovniProfesorForm(id_profesora);
                    form.Show();
                }
                else if (radioButton2.Checked)
                {
                if (proveraRazrednog(id_profesora))
                {
                    RazredniForm form = new RazredniForm(id_profesora);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Niste razredni staresina!");
                }
                }
                
            
        }

        private bool proveraRazrednog(string id)
        {
            List<Odeljenje> odeljenja = new List<Odeljenje>();
            odeljenja = DataProvider.VratiOdeljenja();
            foreach (Odeljenje od in odeljenja)
            {
                if (od.profesorID == id_profesora)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
