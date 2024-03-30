using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.DetalleingVistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.InterfazInicioSesionVista;
using SistemasVentas.VISTA.InterfazVendedorVista;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.ProveeVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.TipoProdVistas;
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

namespace SistemasVentas.VISTA.InterfazGerenteVista
{
    public partial class InterfazGerenteMenu : Form
    {
        public InterfazGerenteMenu()
        {
            InitializeComponent();
            // Configuración del tamaño del FlowLayoutPanel
            flowLayoutPanel1.AutoSize = true; // Para ajustar automáticamente la altura
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown; // Configurar los controles para que se coloquen de arriba hacia abajo
            flowLayoutPanel1.WrapContents = false; // Evitar el salto a una nueva fila

            // Configuración del Panel para desplazamiento automático
            panel1.AutoScroll = true;

        }
        private void AbrirFormHija(Object FormHija)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RolInterfaz());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new PersonaInterfaz());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new TipoProdInterfaz());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MarcaInterfaz());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ProveedorInterfaz());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new UsuarioVistas.UsuarioInterfaz());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new UsuarioRolVistas.UsuarioRolInterfaz());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ClienteInterfaz());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new IngresoInterfaz());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new VentaInterfaz());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ProductoInterfaz());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ProveeInterfaz());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DetalleVentaInterfaz());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DetalleingInterfaz());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cerrar la sesion?", "CERRAR SESION", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                InterfazinicioSesionMenu abrir = new InterfazinicioSesionMenu();
                abrir.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MenuGerente());
        }

        private void InterfazGerenteMenu_Load(object sender, EventArgs e)
        {
            pictureBox2_Click(null, e);
        }
    }
}
