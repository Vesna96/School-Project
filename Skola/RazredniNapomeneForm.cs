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
    public partial class RazredniNapomeneForm : Form
    {
        public string id_odeljenja;
        public RazredniNapomeneForm()
        {
            InitializeComponent();
        }

        public RazredniNapomeneForm(string id)
        {
            this.id_odeljenja = id;
            InitializeComponent();
        }

        private void RazredniNapomeneForm_Load(object sender, EventArgs e)
        {
            this.Popuni_Formu();
        }

        private void Popuni_Formu()
        {
            List<Cas> casovi = new List<Cas>();
            casovi = DataProvider.VratiCasove(id_odeljenja);
            
            foreach (Cas cas in casovi)
            {
                ListViewItem item = new ListViewItem(new string[] { cas.casID, cas.datumCas, cas.napomena, cas.imeProfesor, cas.prezimeProfesor });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
    }
}
