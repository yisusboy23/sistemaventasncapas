using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInterfaz : Form
    {
        public UsuarioInterfaz()
        {
            InitializeComponent();
        }
        UsuarioBSS bss = new UsuarioBSS();
        PersonaBss bssuser = new PersonaBss();
        public static int IdPersonaSeleccionada = 0;
        private void UsuarioInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                Usuario u = new Usuario();
                u.IdPersona = IdPersonaSeleccionada;
                u.NombreUser = textBox2.Text;
                u.Contraseña = textBox3.Text;
                u.FechaReg = dateTimePicker1.Value;

                bss.InsertarUsuarioBss(u);
                MessageBox.Show("Se guardó correctamente el usuario");

                dataGridView1.DataSource = bss.ListarUsuarioBss();
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
                int IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Usuario editarUsuario = bss.ObtenerUsuarioIdBss(IdUsuarioSeleccionada);
                editarUsuario.IdPersona = IdPersonaSeleccionada;
                editarUsuario.NombreUser = textBox2.Text;
                editarUsuario.Contraseña = textBox3.Text;
                editarUsuario.FechaReg = dateTimePicker1.Value;
                bss.EditarUsuarioBss(editarUsuario);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarUsuarioBss();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a este usuario?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdUsuarioSeleccionada);
                dataGridView1.DataSource = bss.ListarUsuarioBss();
            }
        }
    }
}
