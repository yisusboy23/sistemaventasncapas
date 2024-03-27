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
            flowLayoutPanel1.Width = panel1.ClientSize.Width; // Ancho igual al del panel
            flowLayoutPanel1.AutoSize = true; // Para ajustar automáticamente la altura

            // Configuración del Panel para desplazamiento automático
            panel1.AutoScroll = true;

            // Agregar botones al FlowLayoutPanel
            for (int i = 0; i < 20; i++)
            {
                Button button = new Button();
                button.Text = "Botón " + (i + 1);
                button.Width = flowLayoutPanel1.ClientSize.Width - SystemInformation.VerticalScrollBarWidth; // Ajustar ancho para tener en cuenta la barra de desplazamiento vertical
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
