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

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        UsuarioRolBSS bSS = new UsuarioRolBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol u = new UsuarioRol();
            u.IdUsuario= Convert.ToInt32(textBox1.Text);
            u.IdRol = Convert.ToInt32(textBox2.Text);
            u.FechaAsigna = dateTimePicker1.Value;

            bSS.InsertarUsuarioRolBss(u);
            MessageBox.Show("Se guardo correctamente El Usuario Rol");
        }
    }
}
