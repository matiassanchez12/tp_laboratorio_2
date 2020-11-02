using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using EntidadesAbstractas;
using ClasesInstanciables;
using Excepciones;

namespace TP3UnitTest
{
    [TestClass]
    public class TP3TestsUnitarios
    {
        [TestMethod]
        public void DNI_Invalido_De_Alumno()
        {
            //Arrange
            string DniErroneo = "1000a";
            try
            {
                Alumno alumno1 = new Alumno(2, "Samuel", "Santos", DniErroneo, Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", DniErroneo);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }
        [TestMethod]
        public void Leer_Archivo_Inexistente()
        {
            //Arrange
            Texto archivoTxt = new Texto();
            string datos;
            //Act y Assert
            try
            {
                archivoTxt.Leer("example.txt", out datos);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ArchivosException));
            }
        }

        [TestMethod]
        public void Igualacion_De_Alumno_Con_Null()
        {
            //Arrange
            Alumno alumno1 = new Alumno(2, "Samuel", "Santos", "22222222", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            bool perteneceAlaClase = false;
            //Act y Assert
            try
            {
                perteneceAlaClase = alumno1 == null;
                Assert.Fail("Sin excepción para la comparacion del alumno con la clase: {0}.", perteneceAlaClase.ToString());
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NullReferenceException));
            }
        }

        [TestMethod]
        public void Agregar_Alumnos_A_Coleccion_De_Alumnos_Ok()
        {
            //Arrange
            int lenghtUni1 = 3;
            Alumno a1 = new Alumno(1, "Roberto", "Daleri", "11111111", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno a2 = new Alumno(2, "Maria", "Peralta", "22222222", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno a3 = new Alumno(3, "Ana", "Villalba", "99999998", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            Universidad uni1 = new Universidad();
            //Act 
            uni1 += a1;
            uni1 += a2;
            uni1 += a3;
            //Assert
            Assert.AreEqual(uni1.Alumnos.Count, lenghtUni1);
        }
    }
}
