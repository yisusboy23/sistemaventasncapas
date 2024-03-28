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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolDatosVista : Form
    {
        public RolDatosVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void RolDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.RolDatosBSS();
        }
    }
}
