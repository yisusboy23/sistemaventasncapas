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

namespace SistemasVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdListarVistas : Form
    {
        public TipoProdListarVistas()
        {
            InitializeComponent();
        }
        TipoProdBSS bss= new TipoProdBSS();
        private void TipoProdListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }
    }
}
