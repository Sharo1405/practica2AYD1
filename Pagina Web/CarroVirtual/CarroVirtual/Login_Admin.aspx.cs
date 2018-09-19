using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class Login_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botoningresar(object sender, EventArgs e)
        {
            String nombre = Username.Text;
            String contrasenia = Password.Text;
            if (nombre.ToLower().Equals("administrador") && contrasenia.ToLower().Equals("1234"))
            {
                Response.Redirect("indexAdmin.aspx");
            }
            else
            {
                Conexion.MsgBox("Usuario o Contraseña erroneos", this.Page, this);
            }
            Username.Text = "";
            Password.Text = "";
        }
    }
}