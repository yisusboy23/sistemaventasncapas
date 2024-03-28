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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoDatosVistas : Form
    {
        public ProductoDatosVistas()
        {
            InitializeComponent();
        }
        ProductoBSS bss = new ProductoBSS();
        private void ProductoDatosVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }
    }
}
