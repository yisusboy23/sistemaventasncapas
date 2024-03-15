﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDAL
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioRolDAL(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuariorol values(" + usuarioRol.IdUsuario+ "," +
                                                          "'" + usuarioRol.IdRol + "'," +
                                                          "'" + usuarioRol.FechaAsigna + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
