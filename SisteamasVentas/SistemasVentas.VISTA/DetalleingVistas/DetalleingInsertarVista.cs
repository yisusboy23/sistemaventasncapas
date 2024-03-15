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

namespace SistemasVentas.VISTA.DetalleingVistas
{
    public partial class DetalleingInsertarVista : Form
    {
        public DetalleingInsertarVista()
        {
            InitializeComponent();
        }
        DetalleingBSS bss = new DetalleingBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Detalleing d = new Detalleing();
            d.IdIngreso= Convert.ToInt32(textBox1.Text);
            d.IdProducto = Convert.ToInt32(textBox2.Text);
            d.FechaVenc = dateTimePicker1.Value;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioCosto = Convert.ToDecimal(textBox4.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            d.SubTotal = Convert.ToDecimal(textBox6.Text);

            bss.InsertarDetalleingBss(d);
            MessageBox.Show("Se guardo correctamente Detalleing");
        }
    }
}
