﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class eliminarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            //OBTENGO EL PRODUCTO SELECCIONADO
            int cod_producto;
            try
            {
                cod_producto = Convert.ToInt32(txt_codigo.Text);
            }
            catch (Exception)
            {
                return;
            }
            Conexion.EliminarProducto(cod_producto);

            Conexion.MsgBox("Producto Eliminado con éxito!",this.Page,this);
        }

        void CambiarImagen()
        {
            //OBTENGO EL PRODUCTO SELECCIONADO
            int cod_producto;
            try
            {
                cod_producto = Convert.ToInt32(txt_codigo.Text);
            }
            catch (Exception)
            {
                return;
            }
            byte[] imagen = Conexion.ObtenerImagenProducto(cod_producto);

            //MUESTRO LA IMAGEN
            String base64String = Convert.ToBase64String(Conexion.ObtenerImagenProducto(cod_producto), 0, Conexion.ObtenerImagenProducto(cod_producto).Length);
            imgProducto.ImageUrl = "data:image/jpeg;base64," + base64String;
        }

        protected void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            //BUSCO EL PRODUCTO POR NOMBRE O POR CODIGO
            Producto producto = Conexion.BuscarProducto(txt_buscar.Text);

            //MUESTRO LOS VALORES OBTENIDOS
            txt_codigo.Text = producto.cod_producto.ToString();
            txt_nombre.Text = producto.nombre;
            combo_categoria.SelectedIndex = producto.categoria_cod_categoria;
            CambiarImagen();
        }
    }
}