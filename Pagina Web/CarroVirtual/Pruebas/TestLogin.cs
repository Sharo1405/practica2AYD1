using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;

namespace Pruebas
{
    [TestClass]
    public class TestLogin
    {
        [TestMethod]
        public void Login_Correcto()
        {
            int resultado = 1;
            int realizado = Gestion_Login.Ingreso("administrador","1234");
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
        }

        [TestMethod]
        public void Login_InCorrecto()
        {
            int resultado = 0;
            int realizado = Gestion_Login.Ingreso("Administrador", "1234");
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
        }

        [TestMethod]
        public void Login_InCorrecto_nombre()
        {
            int resultado = 0;
            int realizado = Gestion_Login.Ingreso("", "1234");
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
        }

        [TestMethod]
        public void Login_InCorrecto_contrasenia()
        {
            int resultado = 0;
            int realizado = Gestion_Login.Ingreso("", "1234");
            try
            {
                Assert.AreEqual(resultado, realizado);
            }
            catch
            {

            }
        }
    }
}
