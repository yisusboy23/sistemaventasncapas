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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorDatosVista : Form
    {
        public ProveedorDatosVista()
        {
            InitializeComponent();
        }
        ProveedorBSS bss = new ProveedorBSS();
        private void ProveedorDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveedorDatosBSS();
        }
    }
}
