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
    public class ProveedorBSS
    {
        ProveedorDAL dal = new ProveedorDAL();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
        public void InsertarProveedorBss(Proveedor proveedor)
        {
            dal.InsertarProveedorDAL(proveedor);
        }
    }
}
