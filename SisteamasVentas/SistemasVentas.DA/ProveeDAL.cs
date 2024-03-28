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
        Provee p = new Provee();
        public Provee ObtenerProveeIdDal(int id)
        {
            string consulta = "select * from provee where idprovee=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdProvee = Convert.ToInt32(tabla.Rows[0]["idprovee"]);
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                p.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                p.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
            }
            return p;
        }
        public void EditarProveeDal(Provee p)
        {
            string consulta = "update provee set idproducto=" + p.IdProducto + "," +
                                                        "idproveedor=" + p.IdProveedor + "," +
                                                        "fecha='" + p.Fecha + "'," +
                                                        "precio=" + p.Precio + " " +
                                                "where idprovee=" + p.IdProvee;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProveeDal(int id)
        {
            string consulta = "delete from provee where idprovee=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable ProveeDatosDal()
        {
            string consulta = "  SELECT PRODUCTO.NOMBRE, TIPOPROD.NOMBRE AS Expr1, MARCA.NOMBRE AS Expr2, PROVEEDOR.NOMBRE AS Expr3, PROVEEDOR.TELEFONO, PROVEE.FECHA, PROVEE.PRECIO " +
                               " FROM PROVEE INNER JOIN " +
                               " PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN" +
                               " PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR INNER JOIN" +
                               " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA INNER JOIN" +
                               " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
