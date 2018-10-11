using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;

namespace PruebasBDDFuncionales
{
    [Binding]
    public class CrearCategoriaCorrectoSteps
    {
        private String result = "";
        private Gestion_categoria_crud categoria = new Gestion_categoria_crud();
        [Given(@"un nombre no existente como ""(.*)""")]
        public void GivenUnNombreNoExistenteComo(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"de descripcion ""(.*)""")]
        public void GivenDeDescripcion(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"presiono crear categoria")]
        public void WhenPresionoCrearCategoria()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"el sistema debe crear la categoria en el sistema validado con un ""(.*)""")]
        public void ThenElSistemaDebeCrearLaCategoriaEnElSistemaValidadoConUn(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
