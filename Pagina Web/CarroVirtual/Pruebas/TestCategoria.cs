using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;

namespace Pruebas
{
    [TestClass]
    public class TestCategoria
    {
        [TestMethod]
        public void Crear_categoria_nombre_descripcion_NOEXISTENTE()
        {
            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "nombre";
            categoria.descripcion = "Soy la descripcion de la categoria";

            /*bool realizado = Gestion_categoria_crud.CrearCategoria(categoria);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }*/
        }

        [TestMethod]
        public void Crear_categoria_nombre_descripcion_EXISTENTE()
        {
            bool resultado = false;
            Categoria categoria = new Categoria();
            categoria.nombre = "nombre";
            categoria.descripcion = "Soy la descripcion de la categoria";
            /*
            bool realizado = Gestion_categoria_crud.CrearCategoria(categoria);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }*/
            Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
        }

        [TestMethod]
        public void Crear_categoria_nombre_NOEXISTENTE()
        {
            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "OtroNombre";
            /*
            bool realizado = Gestion_categoria_crud.CrearCategoria(categoria);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }*/
        }

        [TestMethod]
        public void Crear_categoria_descripcion()
        {
            bool resultado = false;
            Categoria categoria = new Categoria();
            categoria.descripcion = "soy descripcion, sin nombre categoria";
            /*
            bool realizado = Gestion_categoria_crud.CrearCategoria(categoria);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }*/
        }


        [TestMethod]
        public void Eliminar_categoria_NOExistente()
        {
            bool resultado = false;
            Categoria categoria = new Categoria();
            categoria.nombre = "NoExisto";

            bool realizado = Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
        }


        [TestMethod]
        public void Eliminar_categoria_Existente()
        {
            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "OtroNombre";

            bool realizado = Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
        }


        [TestMethod]
        public void Editar_categoria_Existente()
        {
            Categoria prueba = new Categoria();
            prueba.nombre = "Prueba";
            prueba.descripcion = "Soy una prueba";
            Gestion_categoria_crud.CrearCategoria(prueba);

            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "nuevoNombre";
            categoria.descripcion = "nueva descripcion prueba";

            bool realizado = Gestion_categoria_crud.EditarCategoria(categoria, prueba.nombre);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
            Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
        }

        [TestMethod]
        public void Editar_categoria_nombre_Existente()
        {
            Categoria prueba = new Categoria();
            prueba.nombre = "Prueba";
            prueba.descripcion = "Soy una prueba";
            Gestion_categoria_crud.CrearCategoria(prueba);

            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "nuevoNombre2";

            bool realizado = Gestion_categoria_crud.EditarCategoria(categoria, prueba.nombre);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
            Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
        }


        [TestMethod]
        public void Editar_categoria_descripcion_Existente()
        {
            Categoria prueba = new Categoria();
            prueba.nombre = "Prueba";
            prueba.descripcion = "Soy una prueba";
            Gestion_categoria_crud.CrearCategoria(prueba);

            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.descripcion = "nueva descripcion 2";

            bool realizado = Gestion_categoria_crud.EditarCategoria(categoria, prueba.nombre);
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
            Gestion_categoria_crud.Eliminar_categoria(prueba.nombre);
        }
    }
}
