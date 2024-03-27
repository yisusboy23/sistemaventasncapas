﻿using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolInterfaz : Form
    {
        public RolInterfaz()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void RolInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarRolBss();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rol m = new Rol();
            m.Nombre = textBox1.Text;

            bss.InsertarRolBss(m);
            MessageBox.Show("Se guardo correctamente la marca");
            dataGridView1.DataSource = bss.ListarRolBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Rol editarMarca = bss.ObtenerRolIdBss(IdMarcaSeleccionada);
            editarMarca.Nombre = textBox1.Text;
            bss.EditarRolBss(editarMarca);
            MessageBox.Show("Datos Actualizados");


            dataGridView1.DataSource = bss.ListarRolBss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta persona?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarRolBss(IdMarcaSeleccionada);
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }
    }
}
