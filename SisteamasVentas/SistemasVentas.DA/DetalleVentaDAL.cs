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
        DetalleVenta p = new DetalleVenta();
        public DetalleVenta ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdDetaleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                p.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                p.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                p.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarDetalleVentaDal(DetalleVenta p)
        {
            string consulta = "update detalleventa set idventa=" + p.IdVenta + "," +
                                                        "idproducto=" + p.IdProducto + "," +
                                                        "cantidad=" + p.Cantidad + "," +
                                                        "precioventa=" + p.PrecioVenta + "," +
                                                        "subtotal=" + p.SubTotal + " " +
                                                "where iddetalleventa=" + p.IdDetaleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable DetalleVentaDatosDal()
        {
            string consulta = " SELECT PRODUCTO.NOMBRE, TIPOPROD.NOMBRE AS Expr1, MARCA.NOMBRE AS Expr2, PROVEEDOR.NOMBRE AS Expr3, PROVEEDOR.TELEFONO, PROVEE.FECHA, PROVEE.PRECIO " +
                               "FROM PROVEE INNER JOIN " +
                               " PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN" +
                               " PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR INNER JOIN" +
                               " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA INNER JOIN " +
                               " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
