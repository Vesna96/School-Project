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
    public partial class RazredniIzostanciForm : Form
    {
        public string id_odeljenja;
        public bool FullRowSelect { get; set; }

        public RazredniIzostanciForm()
        {
            InitializeComponent();
        }

        public RazredniIzostanciForm(string id)
        {
            this.id_odeljenja = id;
            InitializeComponent();
        }

        private void RazredniIzostanciForm_Load(object sender, EventArgs e)
        {
            this.Popuni_Formu();
        }

        private void Popuni_Formu()
        {
            
            List<Izostanak> izostanci = DataProvider.VratiIzostankeIzOdeljenja(id_odeljenja);
            foreach (Izostanak izo in izostanci)
            {
                if ((izo.tip).Equals("Jos uvek nije opravdan"))
                {
                    ListViewItem item = new ListViewItem(new string[] { izo.ucenikID, izo.imeUcenik, izo.prezimeUcenik, izo.datumIzostanak, izo.casID, izo.tip });
                    listView1.Items.Add(item);
                }
            }
            listView1.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnZapamtiPromene_Click(object sender, EventArgs e)
        {
            if ((listView1.SelectedItems.Count == 1))
            {
                string id_ucenika = listView1.SelectedItems[0].SubItems[0].Text;
                string id_casa = listView1.SelectedItems[0].SubItems[4].Text;
                if (rbOpravdani.Checked)
                {
                    DataProvider.AzurirajIzostanak(id_casa, id_ucenika, "Opravdani");
                    ListViewItem item = listView1.SelectedItems[0];
                    listView1.Items.Remove(item);

                    MessageBox.Show("Izostanak opravdan!");
                    return;
                }
                else if (rbNeopravdani.Checked)
                {
                    DataProvider.AzurirajIzostanak(id_casa, id_ucenika, "Neopravdani");
                    ListViewItem item = listView1.SelectedItems[0];
                    listView1.Items.Remove(item);

                    MessageBox.Show("Izostanak neopravdan!");
                    return;
                }
                else
                    MessageBox.Show("Selektujte Opravdani/Neopravdani!");

            }
            else
                MessageBox.Show("Selektujte ucenika!");
            


        }
    }
}
