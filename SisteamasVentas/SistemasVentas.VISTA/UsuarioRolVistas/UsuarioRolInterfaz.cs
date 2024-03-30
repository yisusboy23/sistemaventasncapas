using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.RolVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInterfaz : Form
    {
        public UsuarioRolInterfaz()
        {
            InitializeComponent();
        }
        UsuarioRolBSS bss = new UsuarioRolBSS();
        UsuarioBSS bssuser = new UsuarioBSS();
        RolBss bssrol = new RolBss();
        public static int IdUsuarioSeleccionada = 0;
        public static int IdRolSeleccionada = 0;
        private void UsuarioRolInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioRolBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionar fr = new UsuarioSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario u = bssuser.ObtenerUsuarioIdBss(IdUsuarioSeleccionada);
                textBox1.Text = u.NombreUser;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RolSeleccionar fr = new RolSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol r = bssrol.ObtenerRolIdBss(IdRolSeleccionada);
                textBox2.Text = r.Nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                UsuarioRol u = new UsuarioRol();
                u.IdUsuario = IdUsuarioSeleccionada;
                u.IdRol = IdRolSeleccionada;
                u.FechaAsigna = dateTimePicker1.Value;

                bss.InsertarUsuarioRolBss(u);
                MessageBox.Show("Se guardo correctamente ");
                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int IdUsuarioRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                UsuarioRol editarUsuarioRol = bss.ObtenerUsuarioRolIdBss(IdUsuarioRolSeleccionada);
                editarUsuarioRol.IdUsuario = IdUsuarioSeleccionada;
                editarUsuarioRol.IdRol = IdRolSeleccionada;
                editarUsuarioRol.FechaAsigna = dateTimePicker1.Value;
                bss.EditarUsuarioRolBss(editarUsuarioRol);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdUsuarioRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a este rol de usuario?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioRolBss(IdUsuarioRolSeleccionada);
                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }
    }
}
