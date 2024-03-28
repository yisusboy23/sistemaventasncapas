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

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaDatosVista : Form
    {
        public PersonaDatosVista()
        {
            InitializeComponent();
        }
        PersonaBss bss= new PersonaBss();
        private void PersonaDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.UsuarioDatosBSS();
        }
    }
}
