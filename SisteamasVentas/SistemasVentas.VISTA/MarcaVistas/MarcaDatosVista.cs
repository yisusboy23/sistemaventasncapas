﻿using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaDatosVista : Form
    {
        public MarcaDatosVista()
        {
            InitializeComponent();
        }
        MarcaBSS bss = new MarcaBSS();
        private void MarcaDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.MarcaDatosBSS();
        }
    }
}
