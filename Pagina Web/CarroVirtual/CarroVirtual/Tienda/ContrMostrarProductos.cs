using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Web;

namespace CarroVirtual.Tienda
{
    public class ContrMostrarProductos
    {
        public const int paginationSize = 4;

        internal static List<ProductoCarrito> BuscarProductos(string categoria, string posibleNombre, int pagina) //busqueda por nombre o código
        {
            List<ProductoCarrito> productosMostrados = new List<ProductoCarrito>();
            ProductoCarrito producto;

            string OBTENER_PRODUCTOS = "SELECT  P.NOMBRE NOMBRE, " +
                                                        "P.PRECIO_VENTA PRECIO, " +
                                                        "P.IMAGEN IMAGEN, " +
                                                        "C.nombre CATEGORIA "
                                                + "FROM producto  P, CATEGORIA C "
                                                + "WHERE P.categoria_cod_categoria = C.cod_categoria "
                                                + "AND C.NOMBRE LIKE '%"+ categoria + "%' "
                                                + "AND P.NOMBRE LIKE '%"+ posibleNombre  + "%' "
                                                + "ORDER BY P.NOMBRE "
                                                + "OFFSET @PRODUCTOSMOSTRADOS ROWS "
                                                + "FETCH NEXT @PAGINADO ROWS ONLY "
                                                + ";";

            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand(OBTENER_PRODUCTOS, con);
            cmd.Parameters.AddWithValue("@PRODUCTOSMOSTRADOS", pagina* paginationSize);
            cmd.Parameters.AddWithValue("@PAGINADO", paginationSize);

            SqlDataReader reader = cmd.ExecuteReader();

            
            while (reader.Read())
            {
                producto = new ProductoCarrito();
                producto.nombre = (String)reader["NOMBRE"];
                producto.precio = (Int32)reader["PRECIO"];
                //
                byte[] imagen = (byte[])(reader["IMAGEN"]);
                String base64String = Convert.ToBase64String(imagen, 0, imagen.Length);
                producto.imagenURL = "data:image/jpeg;base64," + base64String;
                //
                producto.categoria = (String)(reader["CATEGORIA"]);
                productosMostrados.Add(producto);
                
            }

            con.Close();

            return productosMostrados;
        }

        internal static void VaciarCarro()
        {
            string cad = "TRUNCATE TABLE carro;";

            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand(cad, con);

            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();            
        }

        internal static List<ProductoCarrito> BuscarProductCar() //busqueda 
        {
            List<ProductoCarrito> productosMostrados = new List<ProductoCarrito>();
            ProductoCarrito producto;

            string OBTENER_PRODUCTOS = "SELECT  P.NOMBRE NOMBRE, " +
                                                        "p.cantidad CANTIDAD, "+
                                                        "P.PRECIO_VENTA PRECIO, " +
                                                        "P.IMAGEN IMAGEN, " +
                                                        "C.nombre CATEGORIA "
                                                + "FROM producto  P, CATEGORIA C, carro ca "
                                                + "WHERE ca.producto_cod_producto = p.cod_producto and "
                                                + "P.categoria_cod_categoria = C.cod_categoria "                                              
                                                + "ORDER BY P.NOMBRE "                                              
                                                + ";";

            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand(OBTENER_PRODUCTOS, con);            

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                producto = new ProductoCarrito();
                producto.nombre = (String)reader["NOMBRE"];
                producto.cantidadDisponible = (Int32)reader["CANTIDAD"];
                producto.precio = (Int32)reader["PRECIO"];                
                //
                byte[] imagen = (byte[])(reader["IMAGEN"]);
                String base64String = Convert.ToBase64String(imagen, 0, imagen.Length);
                producto.imagenURL = "data:image/jpeg;base64," + base64String;
                //
                producto.categoria = (String)(reader["CATEGORIA"]);
                productosMostrados.Add(producto);

            }

            con.Close();

            return productosMostrados;
        }
    }
}