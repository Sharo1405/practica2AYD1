﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;

namespace CarroVirtual
{
    public class Conexion
    {
        public static String cadenaConexion = "Data Source=ING\\SQLEXPRESS;Initial Catalog=p2;Integrated Security=True";

        //<======================= CONEXION A LA BASE DE DATOS ===========================================
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            con.Open();
            return con;
        }

        //<======================= MENSAJES EMERGENTES ===================================================
        public static void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        //<======================== METODOS PRODUCTO =========================================================
        internal static void CrearProducto(Producto producto, Categoria categoria)
        {
            SqlConnection con = ObtenerConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO producto(nombre, cantidad, detalles, precio_venta, imagen, categoria_cod_categoria) VALUES('"+producto.nombre+"', "+producto.cantidad+", '"+producto.detalles+"', "+producto.precio_venta+", @IMAGEN, "+categoria.cod_categoria+")", con);
            cmd.Parameters.Add("@IMAGEN", System.Data.SqlDbType.VarBinary).Value = producto.imagen;
            int s = cmd.ExecuteNonQuery();
            con.Close();
        }

        internal static Producto BuscarProducto(string busqueda) //busqueda por nombre o código
        {
            int cod_producto = 0;
            try { cod_producto = Convert.ToInt32(busqueda); }
            catch (Exception) { }

            Producto producto = new Producto();
            SqlConnection con = ObtenerConexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM producto WHERE nombre LIKE '%" + busqueda + "%' OR cod_producto = " + cod_producto + "", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                producto.nombre = (String)reader["nombre"];
                producto.cod_producto = (Int32)reader["cod_producto"];
                producto.categoria_cod_categoria = (Int32)reader["categoria_cod_categoria"];
                producto.detalles = (String)reader["detalles"];
                producto.precio_venta = (Int32)reader["precio_venta"];
                producto.cantidad = (Int32)reader["cantidad"];
                producto.imagen = (byte[])(reader["imagen"]);
            }
            con.Close();

            return producto;
        }

        internal static void EliminarProducto(int cod_producto)
        {
            SqlConnection con = ObtenerConexion();
            SqlCommand cmd = new SqlCommand("DELETE producto WHERE cod_producto = "+cod_producto+"", con);
            int s = cmd.ExecuteNonQuery();
            con.Close();
        }

        internal static void EditarProducto(Producto producto)
        {
            SqlConnection con = ObtenerConexion();
            SqlCommand cmd = new SqlCommand("UPDATE producto SET nombre = '"+producto.nombre+"', cantidad = "+producto.cantidad+", precio_venta = "+producto.precio_venta+", detalles = '"+producto.detalles+"', categoria_cod_categoria = "+producto.categoria_cod_categoria+", imagen = @IMAGEN WHERE cod_producto = " + producto.cod_producto + "", con);
            cmd.Parameters.Add("@IMAGEN", System.Data.SqlDbType.VarBinary).Value = producto.imagen;
            int s = cmd.ExecuteNonQuery();
            con.Close();
        }

        internal static bool ExisteProducto(Producto producto, Categoria categoria)
        {
            SqlConnection con = ObtenerConexion();
            SqlCommand cmd = new SqlCommand("SELECT cod_producto FROM producto WHERE nombre LIKE '"+producto.nombre+ "' AND categoria_cod_categoria = "+categoria.cod_categoria+"", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        internal static byte[] ObtenerImagenProducto(int cod_producto)
        {
            SqlConnection con = ObtenerConexion();
            SqlCommand cmd = new SqlCommand("SELECT imagen FROM producto WHERE cod_producto=" + cod_producto + ";", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                byte[] img = (byte[])(reader["imagen"]);
                return img;
            }
            con.Close();
            return new byte[1];
        }
    }
}