using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarPersonaDAL(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                          "'" + persona.Apellido + "'," +
                                                          "'" + persona.Telefono + "'," +
                                                          "'" + persona.CI + "'," +
                                                          "'" + persona.Correo + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Persona ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (tabla.Rows.Count > 0)
            {
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["Idpersona"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p.CI = tabla.Rows[0]["ci"].ToString();
                p.Correo = tabla.Rows[0]["correo"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;

        }
    }
}
