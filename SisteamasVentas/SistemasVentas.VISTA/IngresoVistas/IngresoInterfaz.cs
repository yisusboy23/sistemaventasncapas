using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInterfaz : Form
    {
        public IngresoInterfaz()
        {
            InitializeComponent();
        }
        IngresoBSS bss = new IngresoBSS();
        ProveedorBSS bssuser = new ProveedorBSS();
        public static int IdProveedorSeleccionada = 0;
        private void IngresoInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresoBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!decimal.TryParse(textBox2.Text, out decimal total))
            {
                MessageBox.Show("El campo Total solo puede contener números.");
            }
            else
            {
                Ingreso u = new Ingreso();
                u.IdProveedor = IdProveedorSeleccionada;
                u.Total = Convert.ToDecimal(textBox2.Text);
                u.FechaIngreso = dateTimePicker1.Value;

                bss.InsertarIngresoBss(u);
                MessageBox.Show("Se guardo correctamente ");
                dataGridView1.DataSource = bss.ListarIngresoBss();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProveedorSeleccionar fr = new ProveedorSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor u = bssuser.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox1.Text = u.Nombre;
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
            else if (!decimal.TryParse(textBox2.Text, out decimal total))
            {
                MessageBox.Show("El campo Total solo puede contener números.");
            }
            else
            {
                int IdIngresoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Ingreso editarIngreso = bss.ObtenerIngresoIdBss(IdIngresoSeleccionada);
                editarIngreso.IdProveedor = IdProveedorSeleccionada;
                editarIngreso.Total = Convert.ToDecimal(textBox2.Text);
                editarIngreso.FechaIngreso = dateTimePicker1.Value;
                bss.EditarIngresoBss(editarIngreso);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarIngresoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdIngresoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a este ingreso?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarIngresoBss(IdIngresoSeleccionada);
                dataGridView1.DataSource = bss.ListarIngresoBss();
            }
        }
    }
}
