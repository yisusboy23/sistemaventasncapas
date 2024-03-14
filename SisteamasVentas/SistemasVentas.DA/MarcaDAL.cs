using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class MarcaDAL
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from marca";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarMarcaDAL(Marca marca)
        {
            string consulta = "insert into marca values('" + marca.Nombre + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
