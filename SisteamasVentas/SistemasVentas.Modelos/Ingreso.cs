using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Ingreso
    {
        public int IdIngreso { get; set; }
        public int IdProveedor { get; set; }
        public string FechaIngreso { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
    }
}
