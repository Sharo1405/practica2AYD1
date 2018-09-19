using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class Eliminar_categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void eliminar_categoria(object sender, EventArgs e)
        {
            String nombre = txt_nombre.Text;

            bool existe = Gestion_categoria_crud.Eliminar_categoria(nombre);
            if (existe == true)
            {
                Conexion.MsgBox("Categoria Eliminada con éxito!", this.Page, this);
            }
            else
            {
                Conexion.MsgBox("Categoria No existe!!!", this.Page, this);
            }
            txt_nombre.Text = "";
        }
    }
}