using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeInterfaz : Form
    {
        public ProveeInterfaz()
        {
            InitializeComponent();
        }
        ProveeBSS bss = new ProveeBSS();
        ProductoBSS bssprod = new ProductoBSS();
        ProveedorBSS bssprov = new ProveedorBSS();

        public static int IdProductoSeleccionada = 0;
        public static int IdProveedorSeleccionada = 0;
        private void ProveeInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveeBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductoSeleccionar fr = new ProductoSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssprod.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox1.Text = p.Nombre;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProveedorSeleccionar fr = new ProveedorSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor u = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox2.Text = u.Nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!decimal.TryParse(textBox3.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.");
            }
            else
            {
                Provee u = new Provee();
                u.IdProducto = IdProductoSeleccionada;
                u.IdProveedor = IdProveedorSeleccionada;
                u.Fecha = dateTimePicker1.Value;
                u.Precio = Convert.ToDecimal(textBox3.Text);

                bss.InsertarProveeBss(u);
                MessageBox.Show("Se guardo correctamente");
                dataGridView1.DataSource = bss.ListarProveeBss();
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
            else if (!decimal.TryParse(textBox3.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.");
            }
            else
            {
                int IdProveeSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Provee editarProvee = bss.ObtenerProveeIdBss(IdProveeSeleccionada);
                editarProvee.IdProducto = IdProductoSeleccionada;
                editarProvee.IdProveedor = IdProveedorSeleccionada;
                editarProvee.Fecha = dateTimePicker1.Value;
                editarProvee.Precio = Convert.ToDecimal(textBox3.Text);
                bss.EditarProveeBss(editarProvee);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarProveeBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdProveeSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que lo desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveeBss(IdProveeSeleccionada);
                dataGridView1.DataSource = bss.ListarProveeBss();
            }
        }
    }
}
