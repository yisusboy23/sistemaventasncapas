using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleingDAL
    {
        public DataTable ListarDetalleingDal()
        {
            string consulta = "select * from detalleing";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarDetalleingDAL(Detalleing detalleing)
        {
            string consulta = "insert into detalleing values(" + detalleing.IdIngreso + "," +
                                                          "" + detalleing.IdProducto + "," +
                                                          "'" + detalleing.FechaVenc + "'," +
                                                          "'" + detalleing.Cantidad + "'," +
                                                          "'" + detalleing.PrecioCosto + "'," +
                                                          "'" + detalleing.PrecioVenta + "'," +
                                                          "'" + detalleing.SubTotal + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
    }
}
