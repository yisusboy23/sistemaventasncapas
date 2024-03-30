using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInterfaz : Form
    {
        public ClienteInterfaz()
        {
            InitializeComponent();
        }
        ClienteBSS bss = new ClienteBSS();
        PersonaBss bssuser = new PersonaBss();
        public static int IdPersonaSeleccionada = 0;
        private void ClienteInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
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
                Cliente c = new Cliente();
                c.IdPersona = IdPersonaSeleccionada;
                c.TipoCliente = textBox2.Text;
                c.CodigoCliente = textBox3.Text;

                bss.InsertarClienteBss(c);
                MessageBox.Show("Se guardo correctamente ");
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonaSeleccionar fr = new PersonaSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona p = bssuser.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = p.Nombre + " " + p.Apellido;
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
                int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Cliente editarCliente = bss.ObtenerClienteIdBss(IdClienteSeleccionada);
                editarCliente.IdPersona = IdPersonaSeleccionada;
                editarCliente.TipoCliente = textBox2.Text;
                editarCliente.CodigoCliente = textBox3.Text;
                bss.EditarClienteBss(editarCliente);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a este cliente?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdClienteSeleccionada);
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }
    }
}
