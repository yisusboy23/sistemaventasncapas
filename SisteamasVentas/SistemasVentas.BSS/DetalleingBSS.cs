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
    public class DetalleingBSS
    {
        DetalleingDAL dal = new DetalleingDAL();
        public DataTable ListarDetalleingBss()
        {
            return dal.ListarDetalleingDal();
        }

        public void InsertarDetalleingBss(Detalleing detalleing)
        {
            dal.InsertarDetalleingDAL(detalleing);
        }
    }

}
