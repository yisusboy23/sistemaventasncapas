﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class RolDAL
    {
        public DataTable ListarRolDal()
        {
            string consulta = "select * from rol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarRolDAL(Rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
