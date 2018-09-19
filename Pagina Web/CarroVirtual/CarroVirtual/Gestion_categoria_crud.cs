using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarroVirtual
{
    public class Gestion_categoria_crud
    {

        public static void CrearCategoria(Categoria categoria)
        {
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO categoria(nombre, descripcion) " +
                "VALUES('" + categoria.nombre + "', '" + categoria.descripcion + "'" + ")", con);
            int s = cmd.ExecuteNonQuery();
            con.Close();
        }

        public static bool ExisteCategoria(Categoria categoria)
        {
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("SELECT cod_categoria FROM categoria WHERE nombre LIKE '" + 
                categoria.nombre + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public static bool Eliminar_categoria(String nombre)
        {
            int s = 0;
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("DELETE categoria WHERE nombre = '" + nombre + "'", con);
            try
            {
                s = cmd.ExecuteNonQuery();
            }
            catch
            {}
            con.Close();
            if (s>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}