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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaDatosVista : Form
    {
        public VentaDatosVista()
        {
            InitializeComponent();
        }
        VentaBSS bss = new VentaBSS();
        private void VentaDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.VentaDatosBSS();
        }
    }
}
