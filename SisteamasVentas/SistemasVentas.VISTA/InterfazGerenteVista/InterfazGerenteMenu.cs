using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.RolVistas;
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
    }
}
