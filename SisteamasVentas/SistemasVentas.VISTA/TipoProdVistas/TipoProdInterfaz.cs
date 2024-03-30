using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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
    public partial class TipoProdInterfaz : Form
    {
        public TipoProdInterfaz()
        {
            InitializeComponent();
        }
        TipoProdBSS bss = new TipoProdBSS();
        private void TipoProdInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo Nombre está vacío.");
            }
            else
            {
                TipoProd m = new TipoProd();
                m.Nombre = textBox1.Text;

                bss.InsertarTipoProdBss(m);
                MessageBox.Show("Se guardó correctamente");
                dataGridView1.DataSource = bss.ListarTipoProdBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El campo Nombre está vacío.");
            }
            else
            {
                int IdTipoProdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                TipoProd editarTipoProd = bss.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                editarTipoProd.Nombre = textBox1.Text;
                bss.EditarTipoProdBss(editarTipoProd);
                MessageBox.Show("Datos Actualizados");

                dataGridView1.DataSource = bss.ListarTipoProdBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta persona?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarTipoProdBss(IdMarcaSeleccionada);
                dataGridView1.DataSource = bss.ListarTipoProdBss();
            }
        }
    }
}
