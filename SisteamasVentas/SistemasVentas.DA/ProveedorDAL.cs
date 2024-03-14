using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveedorDAL
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProveedorDAL(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "'," +
                                                            "'" + proveedor.Telefono + "'," +
                                                            "'" + proveedor.Direccion + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
