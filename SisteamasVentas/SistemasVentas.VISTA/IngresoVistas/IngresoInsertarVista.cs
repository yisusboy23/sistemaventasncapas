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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        IngresoBSS bss= new IngresoBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.IdProveedor= Convert.ToInt32(textBox1.Text);
            i.FechaIngreso=dateTimePicker1.Value;
            i.Total=Convert.ToDecimal(textBox2.Text);

            bss.InsertarIngresoBss(i);
            MessageBox.Show("Se guardo correctamente El ingreso");
        }
    }
}
