using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveeDAL
    {
        public DataTable ListarProveeDal()
        {
            string consulta = "select * from provee";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarProveeDAL(Provee provee)
        {
            string consulta = "insert into provee values(" + provee.IdProducto + "," +
                                                          "" + provee.IdProveedor + "," +
                                                          "'" + provee.Fecha + "'," +
                                                          " '" + provee.Precio + "')";
            conexion.Ejecutar(consulta);
        }
    }
}
