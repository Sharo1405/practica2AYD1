using System;
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

        public static Boolean inicioSesion = false;

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
    }
}