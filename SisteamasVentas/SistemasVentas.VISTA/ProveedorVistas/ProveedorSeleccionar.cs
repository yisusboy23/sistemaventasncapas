using SistemasVentas.BSS;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProveeVistas;
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
    public partial class ProveedorSeleccionar : Form
    {
        public ProveedorSeleccionar()
        {
            InitializeComponent();
        }
        ProveedorBSS bss = new ProveedorBSS();
        private void ProveedorSeleccionar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoInterfaz.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeInterfaz.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
