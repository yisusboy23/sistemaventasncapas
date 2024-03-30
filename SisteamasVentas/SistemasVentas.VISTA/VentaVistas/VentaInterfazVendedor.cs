using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVistas;
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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaInterfazVendedor : Form
    {
        public VentaInterfazVendedor()
        {
            InitializeComponent();
        }
        VentaBSS bss = new VentaBSS();
        ClienteBSS bsscli = new ClienteBSS();
        UsuarioBSS bssuser = new UsuarioBSS();
        public static int IdClienteSeleccionada = 0;
        public static int IdUsuarioSeleccionada = 0;
        private void VentaInterfazVendedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClienteSeleccionar fr = new ClienteSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente c = bsscli.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox1.Text = c.TipoCliente;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionar fr = new UsuarioSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario u = bssuser.ObtenerUsuarioIdBss(IdUsuarioSeleccionada);
                textBox2.Text = u.NombreUser;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                Venta u = new Venta();
                u.IdCliente = IdClienteSeleccionada;
                u.IdVendedor = IdUsuarioSeleccionada;
                u.Total = Convert.ToDecimal(textBox3.Text);
                u.Fecha = dateTimePicker1.Value;

                bss.InsertarVentaBss(u);
                MessageBox.Show("Se guardo correctamente ");
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
