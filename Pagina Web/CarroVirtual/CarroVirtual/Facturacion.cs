using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarroVirtual
{
    public class Facturacion
    {
       internal static int RealizarCompra(Factura factura, List<Producto> productos)
        {
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO Factura(Nombre,Apellido,DPI,zona_entrega,fecha) VALUES('" + factura.Nombre + "', " + factura.Apellido + ", '" + factura.Dpi + "', '" + factura.Zona + "','" + factura.Fecha + "')", con);
            int s = cmd.ExecuteNonQuery();
            con.Close();
            con = Conexion.ObtenerConexion();
            cmd = new SqlCommand("SELECT cod_factura FROM factura where Nombre='" + factura.Nombre + "' and Apellido='" + factura.Apellido + "' and DPI='" + factura.Dpi + "' and zona_entrega='" + factura.Zona + "' and fecha ='" + factura.Fecha + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            int codigo=-1;
            while (reader.Read())
            {
                codigo = (int)reader["cod_factura"];
            }
            con.Close();

            con = Conexion.ObtenerConexion();
            if (codigo > 0)
            {
                foreach (Producto prod in productos)
                {
                    cmd = new SqlCommand("INSERT INTO detalle_factura (detalle_cod_factura, producto_cod_producto) VALUES(" + codigo + "," + prod.cod_producto + ")");
                    s = cmd.ExecuteNonQuery();
                }
            }
            else
                s = 0;

            con.Close();         
            return s;
        }
    }
}