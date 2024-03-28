using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaDatosVista : Form
    {
        public DetalleVentaDatosVista()
        {
            InitializeComponent();
        }
        DetalleVentaBSS bss = new DetalleVentaBSS();
        private void DetalleVentaDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetalleVentaDatosBSS();
        }
    }
}
