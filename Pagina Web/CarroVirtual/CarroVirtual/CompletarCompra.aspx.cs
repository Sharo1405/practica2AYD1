using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class CompletarCompra : System.Web.UI.Page
    {
        List<ProductoCarrito> productos=null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn2_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tienda/ListadoCarrito.aspx");
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "" && txt_apellido.Text != "" && txt_direccion.Text != "" && txt_dpi.Text != "")
            {
                Factura factura = new Factura();
                factura.Nombre = txt_nombre.Text;
                factura.Apellido = txt_apellido.Text;
                factura.Dpi = txt_dpi.Text;
                factura.Zona = txt_direccion.Text;
                factura.Fecha = DateTime.Now.Date.ToString();
                if (Facturacion.RealizarCompra(factura, productos) > 0)
                {
                    Conexion.MsgBox("Compra realizada con exito!", this.Page, this);
                    txt_apellido.Text = "";
                    txt_nombre.Text = "";
                    txt_dpi.Text = "";
                    txt_direccion.Text = "";
                    txt_nombre.Focus();
                }
                else
                {
                    Conexion.MsgBox("Compra fallida compruebe que tiene productos agregados al carrito!", this.Page, this);
                    txt_nombre.Focus();
                }
            }
            else
            {
                Conexion.MsgBox("Debe llenar todos los campos solicitados!", this.Page, this);
                txt_nombre.Focus();
            }
        }
    }
}