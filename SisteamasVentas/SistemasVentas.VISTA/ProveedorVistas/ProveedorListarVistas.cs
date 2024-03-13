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
    public partial class ProveedorListarVistas : Form
    {
        public ProveedorListarVistas()
        {
            InitializeComponent();
        }
        ProveedorBSS bss= new ProveedorBSS();
        private void ProveedorListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorlBss;
        }
    }
}
