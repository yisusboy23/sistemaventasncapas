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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoDatosVista : Form
    {
        public IngresoDatosVista()
        {
            InitializeComponent();
        }
        IngresoBSS bss = new IngresoBSS();
        private void IngresoDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.IngresoDatosBSS();
        }
    }
}
