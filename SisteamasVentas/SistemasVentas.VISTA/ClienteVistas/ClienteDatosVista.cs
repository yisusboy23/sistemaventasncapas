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

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteDatosVista : Form
    {
        public ClienteDatosVista()
        {
            InitializeComponent();
        }
        ClienteBSS bss = new ClienteBSS();
        private void ClienteDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteDatosBSS();
        }
    }
}
