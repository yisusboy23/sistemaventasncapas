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

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolListarVistas : Form
    {
        public UsuarioRolListarVistas()
        {
            InitializeComponent();
        }
        UsuarioRolBSS bss = new UsuarioRolBSS();
        private void UsuarioRolListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioRolBss();
        }
    }
}
