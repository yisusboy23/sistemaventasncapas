
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

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaInterfaz : Form
    {
        public PersonaInterfaz()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void PersonaInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo Nombre está vacío.");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El campo Apellido está vacío.");
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("El campo Teléfono está vacío.");
            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("El campo CI está vacío.");
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("El campo Correo está vacío.");
            }
            else
            {
                Persona p = new Persona();
                p.Nombre = textBox1.Text;
                p.Apellido = textBox2.Text;
                p.Telefono = textBox3.Text;
                p.CI = textBox4.Text;
                p.Correo = textBox5.Text;

                bss.InsertarPersonaBss(p);
                MessageBox.Show("Se guardó correctamente");

                dataGridView1.DataSource = bss.ListarPersonaBss();
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

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo Nombre está vacío.");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El campo Apellido está vacío.");
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("El campo Teléfono está vacío.");
            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("El campo CI está vacío.");
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("El campo Correo está vacío.");
            }
            else
            {

                int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Persona editarPersona = bss.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                editarPersona.Nombre = textBox1.Text;
                editarPersona.Apellido = textBox2.Text;
                editarPersona.Telefono = textBox3.Text;
                editarPersona.CI = textBox4.Text;
                editarPersona.Correo = textBox5.Text;

                bss.EditarPersonaBss(editarPersona);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarPersonaBss();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta persona?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPersonaBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }
    }

}
