using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class VentaBSS
    {
        VentaDAL dal = new VentaDAL();
        public DataTable ListarVentaBss()
        {
            return dal.ListarVentaDal();
        }

        public void InsertarVentaBss(Venta venta)
        {
            dal.InsertarVentaDAL(venta);
        }
    }
}
