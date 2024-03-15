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

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaIngresarVista : Form
    {
        public DetalleVentaIngresarVista()
        {
            InitializeComponent();
        }
        DetalleVentaBSS bss = new DetalleVentaBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta();
            d.IdVenta = Convert.ToInt32(textBox1.Text);
            d.IdProducto = Convert.ToInt32(textBox2.Text);
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            d.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleVentaBss(d);
            MessageBox.Show("Se guardo correctamente El detalle de la venta");
        }
    }
}
