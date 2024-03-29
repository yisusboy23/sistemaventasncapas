using SistemasVentas.BSS;
using SistemasVentas.VISTA.DetalleingVistas;
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
    public partial class IngresoSeleccionar : Form
    {
        public IngresoSeleccionar()
        {
            InitializeComponent();
        }
        IngresoBSS bss = new IngresoBSS();
        private void IngresoSeleccionar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleingInterfaz.IdIngresoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
