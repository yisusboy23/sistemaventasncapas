using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDAL
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarIngresoDAL(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values(" + ingreso.IdProveedor + "," +
                                                          "'" + ingreso.FechaIngreso + "'," +
                                                          "'" + ingreso.Total + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
