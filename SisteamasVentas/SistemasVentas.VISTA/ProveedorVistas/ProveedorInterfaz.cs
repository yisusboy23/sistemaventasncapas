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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorInterfaz : Form
    {
        public ProveedorInterfaz()
        {
            InitializeComponent();
        }
        ProveedorBSS bss = new ProveedorBSS();
        private void ProveedorInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                Proveedor p = new Proveedor();
                p.Nombre = textBox1.Text;
                p.Telefono = textBox2.Text;
                p.Direccion = textBox3.Text;

                bss.InsertarProveedorBss(p);
                MessageBox.Show("Se guardó correctamente");

                dataGridView1.DataSource = bss.ListarProveedorBss();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Proveedor editarProveedor = bss.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                editarProveedor.Nombre = textBox1.Text;
                editarProveedor.Telefono = textBox2.Text;
                editarProveedor.Direccion = textBox3.Text;
                bss.EditarProveedorBss(editarProveedor);
                MessageBox.Show("Datos Actualizados");

                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta persona?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveedorBss(IdProveedorSeleccionada);
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }
    }
}
