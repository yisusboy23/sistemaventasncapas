using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProductoVIstas;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInterfaz : Form
    {
        public DetalleVentaInterfaz()
        {
            InitializeComponent();
        }
        DetalleVentaBSS bss = new DetalleVentaBSS();
        VentaBSS bssvent = new VentaBSS();
        ProductoBSS bssprod = new ProductoBSS();
        public static int IdVentaSeleccionada = 0;
        public static int IdProductoSeleccionada = 0;
        private void DetalleVentaInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleVentaBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentaSeleccionar fr = new VentaSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta v = bssvent.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = v.Estado;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductoSeleccionar fr = new ProductoSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssprod.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox2.Text = p.Nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!int.TryParse(textBox3.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
            }
            else if (!decimal.TryParse(textBox4.Text, out decimal precioVenta))
            {
                MessageBox.Show("El precio de venta debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox5.Text, out decimal subTotal))
            {
                MessageBox.Show("El subtotal debe ser un valor numérico válido.");
            }
            else
            {
                DetalleVenta d = new DetalleVenta();
                d.IdVenta = IdVentaSeleccionada;
                d.IdProducto = IdProductoSeleccionada;
                d.Cantidad = Convert.ToInt32(textBox3.Text);
                d.PrecioVenta = Convert.ToDecimal(textBox4.Text);
                d.SubTotal = Convert.ToDecimal(textBox5.Text);

                bss.InsertarDetalleVentaBss(d);
                MessageBox.Show("Se guardo correctamente El detalle de la venta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!int.TryParse(textBox3.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
            }
            else if (!decimal.TryParse(textBox4.Text, out decimal precioVenta))
            {
                MessageBox.Show("El precio de venta debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox5.Text, out decimal subTotal))
            {
                MessageBox.Show("El subtotal debe ser un valor numérico válido.");
            }
            else
            {
                int IdDetalleVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DetalleVenta editarDetalleVenta = bss.ObtenerDetalleVentaIdBss(IdDetalleVentaSeleccionada);
                editarDetalleVenta.IdVenta = IdVentaSeleccionada;
                editarDetalleVenta.IdProducto = IdProductoSeleccionada;
                editarDetalleVenta.Cantidad = Convert.ToInt32(textBox3.Text);
                editarDetalleVenta.PrecioVenta = Convert.ToDecimal(textBox4.Text);
                editarDetalleVenta.SubTotal = Convert.ToDecimal(textBox5.Text);
                bss.EditarDetalleVentaBss(editarDetalleVenta);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarDetalleVentaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdUsuarioRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que lo desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleVentaBss(IdUsuarioRolSeleccionada);
                dataGridView1.DataSource = bss.ListarDetalleVentaBss();
            }
        }
    }
}
