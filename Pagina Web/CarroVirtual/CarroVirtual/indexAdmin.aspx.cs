﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class indexAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_subtitulo.InnerText = "Fecha: " + DateTime.Today.ToString("d");
        }
    }
}