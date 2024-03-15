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
    public class IngresoBSS
    {
        IngresoDAL dal = new IngresoDAL();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresoDal();
        }
        public void InsertarIngresoBss(Ingreso ingreso)
        {
            dal.InsertarIngresoDAL(ingreso);
        }
    }
}
