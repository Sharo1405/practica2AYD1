﻿using Biblioteca1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diagrama.app
{
    public partial class consulta1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void cargar_datos()
        {
            class_con en = new class_con();
            
            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta1;  ", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;

            GridView1.DataBind();

            cs.Close();
        }
        protected void borrar_Click(object sender, EventArgs e)
        {

        }
    }
}