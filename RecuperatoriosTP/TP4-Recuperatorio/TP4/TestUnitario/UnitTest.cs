using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Comprueba que si un cliente ya existe en un negocio no sea
        /// ingresado nuevamente.
        /// </summary>
        [TestMethod]
        public void CargarClienteRepetidoEnNegocio_test()
        {
            bool ret = false;
            Negocio n1 = new Negocio("Negocio1");
            Cliente c1 = new Cliente(1, "Dario", "12312222", EMedioDePago.Debito, 'M');
            Cliente c2 = new Cliente(1, "Dario", "12312222", EMedioDePago.Debito, 'M');

            n1 += c1;
            n1 += c2;

            if(n1 == c2)
            {
                ret = true;
            }

            Assert.IsTrue(ret);
        }
        /// <summary>
        /// Intento leer un archivo con un nombre que no existe en la
        /// ubicacion fijada.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void LeerArchivoTxtInexistente_test()
        {
            bool ret = false;

            Radio r1;
            
           if (Articulo.LeerDatos("ArchivoInexistente", out r1))
           {
              ret = true;
           }
        }
        /// <summary>
        /// Comprueba una excepcion al momento de querer modificar
        /// un articulo en la base de datos con un nombre que no existe.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ConexionDBException))]
        public void ModificarArticuloInexistenteDeLaBD_test()
        {
            bool ret = false;
            TV tv1 = new TV(1, "Tv philco", "Philco", EEstado.Nuevo, 22, 20000);

            if(tv1.ModificarArticuloEnBD("Tv Samsung"))
            {
                ret = true;
            }
        }
    }
}
