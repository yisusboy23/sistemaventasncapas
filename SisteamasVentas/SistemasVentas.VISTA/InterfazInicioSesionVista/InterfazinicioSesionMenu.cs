using SistemasVentas.DAL;
using SistemasVentas.VISTA.InterfazGerenteVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.InterfazInicioSesionVista
{
    public partial class InterfazinicioSesionMenu : Form
    {
        public InterfazinicioSesionMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreuser = textBox1.Text;
            string contraseña = textBox2.Text;

            if (conexion.VerificarCredenciales(nombreuser, contraseña))
            {
                InterfazGerenteMenu abrir = new InterfazGerenteMenu();
                abrir.Show();
            }
            else if (conexion.VerificarCredenciales2(nombreuser, contraseña))
            {
                // Acciones específicas para el segundo rol
                MessageBox.Show("Usuario no tiene roles válidos");
            }
            // Agregar más bloques if según sea necesario para otros roles
            // ...
            else if (conexion.VerificarCredenciales3(nombreuser, contraseña))
            {
                // Otro tipo de usuario (no tiene los roles esperados)
                MessageBox.Show("Usuario no tiene roles válidos");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
