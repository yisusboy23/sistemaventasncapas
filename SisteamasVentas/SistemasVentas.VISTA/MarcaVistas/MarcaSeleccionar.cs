using SistemasVentas.BSS;
using SistemasVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaSeleccionar : Form
    {
        public MarcaSeleccionar()
        {
            InitializeComponent();
        }
        MarcaBSS bss = new MarcaBSS();
        private void MarcaSeleccionar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoInterfaz.IdMarcalSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoInterfazSupervisor.IdMarcalSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
