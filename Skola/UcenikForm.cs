﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skola
{
    public partial class UcenikForm : Form
    {
        public string id_ucenika;
        public UcenikForm()
        {
            InitializeComponent();
        }

        public UcenikForm(string id)
        {
            this.id_ucenika = id;
            InitializeComponent();
        }
    }
}
