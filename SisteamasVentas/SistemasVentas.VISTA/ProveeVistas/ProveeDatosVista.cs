using SistemasVentas.BSS;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeDatosVista : Form
    {
        public ProveeDatosVista()
        {
            InitializeComponent();
        }
        ProveeBSS bss = new ProveeBSS();
        private void ProveeDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveeDatosBSS();
        }
    }
}
