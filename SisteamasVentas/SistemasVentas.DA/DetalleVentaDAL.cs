using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDAL
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleVentaDAL(DetalleVenta detalleventa)
        {
            string consulta = "insert into detalleventa values(" + detalleventa.IdVenta + "," +
                                                          "" + detalleventa.IdProducto + "," +
                                                          "'" + detalleventa.Cantidad + "'," +
                                                          "'" + detalleventa.PrecioVenta + "'," +
                                                          "'" + detalleventa.SubTotal + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
    }
}
