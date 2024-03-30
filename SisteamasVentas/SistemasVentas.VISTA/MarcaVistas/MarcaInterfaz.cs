using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaInterfaz : Form
    {
        public MarcaInterfaz()
        {
            InitializeComponent();
        }
        MarcaBSS bss = new MarcaBSS();
        private void MarcaInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo Nombre está vacío.");
            }
            else
            {
                Marca m = new Marca();
                m.Nombre = textBox1.Text;

                bss.InsertarMarcaBss(m);
                MessageBox.Show("Se guardó correctamente");
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo Nombre está vacío.");
            }
            else
            {
                int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Marca editarMarca = bss.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                editarMarca.Nombre = textBox1.Text;
                bss.EditarMarcaBss(editarMarca);
                MessageBox.Show("Datos Actualizados");

                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta persona?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarMarcaBss(IdMarcaSeleccionada);
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }

}