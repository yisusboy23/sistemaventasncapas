using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDAL
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarVentaDAL(Venta venta)
        {
            string consulta = "insert into venta values(" + venta.IdCliente + "," +
                                                          "" + venta.IdVendedor + "," +
                                                          "'" + venta.Fecha + "'," +
                                                          "'" + venta.Total + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
    }
}
