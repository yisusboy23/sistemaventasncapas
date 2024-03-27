using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemasVentas.DAL
{
    public class conexion
    {

        public static string CONECTAR
        {
            //PCA-03 ----DESKTOP-JDKQ9F6\SQLEXPRESS
            get { return @"Data Source=DESKTOP-JDKQ9F6\SQLEXPRESS; Initial Catalog=TIENDABD; Integrated Security=True; TrustServerCertificate=true;"; }
            //get { return ConfigurationManager.ConnectionStrings["cadena"].ToString(); }
        }
        public static DataSet EjecutarDataSet(string consulta)
        {
            string p = conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "TABLA");
            return ds;
        }

        public static void Ejecutar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            cmd.ExecuteNonQuery();
        }

        public static int EjecutarEscalar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();

            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            int dev = Convert.ToInt32(cmd.ExecuteScalar());
            return dev;
        }
        public static DataTable EjecutarDataTabla(string consulta, string tabla)
        {
            string p = conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(tabla);
            da.Fill(dt);
            return dt;
        }
        public static bool VerificarCredenciales(string usuario, string contraseña)
        {
            string consulta = "SELECT COUNT(1) FROM Usuario AS U " +
                              "INNER JOIN UsuarioRol AS UR ON U.IDUsuario = UR.IDUsuario " +
                              "WHERE U.NombreUser = @Usuario AND U.Contraseña = @Contraseña " +
                              "AND UR.IDRol = 1";

            using (SqlConnection conectar = new SqlConnection(CONECTAR))
            {
                conectar.Open();
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }


        }

        public static bool VerificarCredenciales2(string usuario, string contraseña)
        {
            string consulta = "SELECT COUNT(1) FROM Usuario AS U " +
                              "INNER JOIN UsuarioRol AS UR ON U.IDUsuario = UR.IDUsuario " +
                              "WHERE U.NombreUser = @Usuario AND U.Contraseña = @Contraseña " +
                              "AND UR.IDRol = 2";

            using (SqlConnection conectar = new SqlConnection(CONECTAR))
            {
                conectar.Open();
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }


        }

        public static bool VerificarCredenciales3(string usuario, string contraseña)
        {
            string consulta = "SELECT COUNT(1) FROM Usuario AS U " +
                              "INNER JOIN UsuarioRol AS UR ON U.IDUsuario = UR.IDUsuario " +
                              "WHERE U.NombreUser = @Usuario AND U.Contraseña = @Contraseña " +
                              "AND UR.IDRol = 4";

            using (SqlConnection conectar = new SqlConnection(CONECTAR))
            {
                conectar.Open();
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }


        }
    }
}