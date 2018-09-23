using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;

namespace Pruebas
{
    [TestClass]
    public class TestProducto
    {
        /*
        Nombre: Buscar Producto
        Detalles: buscar por Nombre
         */
        [TestMethod]
        public void BuscarProductoNombre()
        {
            //Arrange
            Producto productoEncontrado = new Producto();
            String nombreABuscar = "Mario";

            //Act
            productoEncontrado = ContrProductos.BuscarProducto(nombreABuscar);

            //Assert
            Assert.AreEqual("Mario bros",productoEncontrado.nombre);
            Assert.AreEqual(54,productoEncontrado.cantidad);
        }

        /*
        Nombre: Buscar Producto
        Detalles: buscar por Codigo
         */
        [TestMethod]
        public void BuscarProductoCodigo()
        {
            //Arrange
            Producto productoEncontrado = new Producto();
            int codigo = 1;

            //Act
            productoEncontrado = ContrProductos.BuscarProducto(codigo.ToString());

            //Assert
            Assert.AreEqual("Mario bros", productoEncontrado.nombre);
            Assert.AreEqual(54, productoEncontrado.cantidad);
        }


    }
}
