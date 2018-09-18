using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarroVirtual
{
    public class Clases
    {

    }

    public class Producto
    {
        public int cod_producto { get; set; }
        public String nombre { get; set; }
        public String detalles { get; set; }
        public int precio_venta { get; set; }
        public int cantidad { get; set; }
        public byte[] imagen { get; set; }
        public int categoria_cod_categoria { get; set; }

        public Producto() {
            this.nombre = "";
            this.detalles = "";
            this.precio_venta = 0;
            this.cantidad = 0;
            this.imagen = new byte[1];
            this.categoria_cod_categoria = 0;
        }
    }

    public class Categoria
    {
        public String nombre { get; set; }
        public int cod_categoria { get; set; }

        public Categoria(){
            this.nombre = "";
            this.cod_categoria = 0;
        }
    }
}