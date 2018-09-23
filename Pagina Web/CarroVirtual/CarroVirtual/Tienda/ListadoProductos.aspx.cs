using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual.Tienda
{
    public partial class Productos : System.Web.UI.Page
    {
        string busquedaNombre = null;
        string categoria = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /* List<ProductoCarrito> listaProductos = new List<ProductoCarrito>()
 ;

             ProductoCarrito producto = new ProductoCarrito();
             producto.nombre = "producto1";
             producto.categoria = "cat";
             producto.precio = 5;

             ProductoCarrito producto2 = new ProductoCarrito();
             producto2.nombre = "producto2";
             producto2.categoria = "cat";
             producto2.precio = 5;

             CardProducto cardProducto = new CardProducto { nombreP = producto.nombre };


             listaProductos.Add(producto);
             listaProductos.Add(producto2);

             this.ListViewCardProducts.DataSource = listaProductos;
             this.ListViewCardProducts.DataBind();*/
        }

        protected void buscarProductos(string nombre, string categoria, int paginacion)
        {
            //BUSCO EL PRODUCTO POR NOMBRE O POR CODIGO
            List<ProductoCarrito> listaProductos = ContrMostrarProductos.BuscarProductos(categoria, nombre, paginacion);

            this.ListViewCardProducts.DataSource = listaProductos;
            this.ListViewCardProducts.DataBind();

        }


        protected void LinkButtonAll_Click(object sender, EventArgs e)
        {
            categoria = null;

            buscarProductos(busquedaNombre, categoria, 0);
        }

        protected void LinkButtonPS_Click(object sender, EventArgs e)
        {
            categoria = "PS";
            buscarProductos(busquedaNombre, categoria, 0);
        }

        protected void LinkButtonNINTENDO_Click(object sender, EventArgs e)
        {
            categoria = "W";
            buscarProductos(busquedaNombre, categoria, 0);
        }

        protected void LinkButtonPC_Click(object sender, EventArgs e)
        {
            categoria = "PC";
            buscarProductos(busquedaNombre, categoria, 0);
        }

        protected void LinkButtonXBOX_Click(object sender, EventArgs e)
        {
            categoria = "XBOX";
            buscarProductos(busquedaNombre, categoria, 0);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            busquedaNombre = searchText.Text;
            if (busquedaNombre != null && busquedaNombre.Trim().Length <= 0)
                busquedaNombre = null;
                

            buscarProductos(busquedaNombre, categoria, 0);
        }


        //ELIMINAR SI NO SIRVE
        private void ShowMessage(string Message, string Title)
        {
            ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert", string.Format("alert('{1}', '{0}');", Message, Title), true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Holabb");
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
            //ShowMessage("Ayuda", "Ayuda");
            Button clickedButton = (Button)sender;
            clickedButton.Text = "...button clicked...";
            clickedButton.Enabled = false;

            // Display the greeting label text.

            //Label1.Text = "Hola";
            /*busquedaNombre = searchText.Text;
            if (busquedaNombre != null && busquedaNombre.Trim().Length <= 0)
                busquedaNombre = null;
            buscarProductos(busquedaNombre, categoria, 0);*/
        }        
        //HASTA ACÁ ELIMINAR
    }
}