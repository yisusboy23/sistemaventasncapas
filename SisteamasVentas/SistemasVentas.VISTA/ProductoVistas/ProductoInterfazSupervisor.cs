using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoInterfazSupervisor : Form
    {
        public ProductoInterfazSupervisor()
        {
            InitializeComponent();
        }
        TipoProdBSS bsstprod = new TipoProdBSS();
        MarcaBSS bssmarc = new MarcaBSS();
        ProductoBSS bss = new ProductoBSS();
        public static int IdTipoProdSeleccionada = 0;
        public static int IdMarcalSeleccionada = 0;
        private void ProductoInterfazSupervisor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TipoProdSeleccionar fr = new TipoProdSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd u = bsstprod.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox1.Text = u.Nombre;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MarcaSeleccionar fr = new MarcaSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca u = bssmarc.ObtenerMarcaIdBss(IdMarcalSeleccionada);
                textBox2.Text = u.Nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!int.TryParse(textBox5.Text, out int unidades))
            {
                MessageBox.Show("El campo 'Unidades' debe ser numérico.");
            }
            else
            {
                Producto u = new Producto();
                u.IdTipoProd = IdTipoProdSeleccionada;
                u.IdMarca = IdMarcalSeleccionada;
                u.Nombre = textBox3.Text;
                u.CodigoBarra = textBox4.Text;
                u.Unidad = Convert.ToInt32(textBox5.Text);
                u.Descripcion = textBox6.Text;

                bss.InsertarProductoBss(u);
                MessageBox.Show("Se guardo correctamente ");
                dataGridView1.DataSource = bss.ListarProductoBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!int.TryParse(textBox5.Text, out int unidades))
            {
                MessageBox.Show("El campo 'Unidades' debe ser numérico.");
            }
            else
            {
                int IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Producto editarProducto = bss.ObtenerProductoIdBss(IdProductoSeleccionada);
                editarProducto.IdTipoProd = IdTipoProdSeleccionada;
                editarProducto.IdMarca = IdMarcalSeleccionada;
                editarProducto.Nombre = textBox3.Text;
                editarProducto.CodigoBarra = textBox4.Text;
                editarProducto.Unidad = Convert.ToInt32(textBox5.Text);
                editarProducto.Descripcion = textBox6.Text;
                bss.EditarProductoBss(editarProducto);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarProductoBss();
            }
        }
    }
}
