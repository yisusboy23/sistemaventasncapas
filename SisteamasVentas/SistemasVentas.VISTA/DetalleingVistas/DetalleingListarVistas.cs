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

namespace SistemasVentas.VISTA.DetalleingVistas
{
    public partial class DetalleingListarVistas : Form
    {
        public DetalleingListarVistas()
        {
            InitializeComponent();
        }
        DetalleingBSS bss = new DetalleingBSS();
        private void DetalleingListarVistas_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = bss.ListarDetalleingBss;
        }
    }
}
