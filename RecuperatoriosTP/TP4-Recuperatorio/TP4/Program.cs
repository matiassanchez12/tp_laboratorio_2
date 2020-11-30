using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primera muestra: Manejo de clases, creo instancias de clientes y articulos y compruebo que se hallan agregado 
            // correctamente a sus respectivas listas de la clase negocio. Para ello utilizo 
            // metodo para mostrar todos los datos por consola en forma de string.
            Console.WriteLine("Test Parte 1 : Clases e instancias");
            //Creo un negocio
            Negocio n1 = new Negocio("Nuevo negocio");

            //Creo clientes 
            Cliente c1 = new Cliente(1, "Maria", "122124561", EMedioDePago.Credito, 'F');
            Cliente c2 = new Cliente(2, "Jose", "323122223", EMedioDePago.MercadoPago, 'M');
            Cliente c3 = new Cliente(3, "Juan", "423312223", EMedioDePago.Credito, 'M');

            //Creo articulos
            TV tv1 = new TV(1, "TV samsung 2' pulgadas", "Samsung", EEstado.Nuevo, 22, 2222);
            TV tv2 = new TV(2, "TV philip 12' pulgadas", "Philip", EEstado.Nuevo, 30, 30222);
            TV tv3 = new TV(3, "TV Xaomi 15' pulgadas", "Xaomi", EEstado.Nuevo, 40, 12000);

            Radio r1 = new Radio(1, "Radio Uniden", "Uniden", EEstado.Usado, 1000, 0);
            Radio r2 = new Radio(2, "Radio Garmin", "Garmin", EEstado.Usado, 1400, 5);
            Radio r3 = new Radio(3, "Radio Teltronic", "Teltronic", EEstado.Nuevo, 1200, 3);
            
            //Agrego Articulos y clientes al Negocio
            n1 += c1;
            n1 += c2;
            n1 += c3;

            n1 += tv1;
            n1 += tv2;
            n1 += tv3;

            n1 += r1;
            n1 += r2;
            n1 += r3;

            //Muestro datos del negocio, con sus clientes y sus articulos
            Console.WriteLine(n1.MostrarDatosNegocio());

            Console.ReadKey();
            Console.Clear();

            // Segunda muestra: Base de datos, compruebo que se puedan traer, eliminar, agregar y/o modificar
            // datos, de forma correcta sin errores ni excepciones.
            Console.WriteLine("Test Parte 2 : Base de datos");

            try
            {
                // Agrego clientes a la BD
                ConexionBD.InsertCliente(c1);
                ConexionBD.InsertCliente(c2);
                // Agrego articulos a la BD
                ConexionBD.InsertArticulo(tv1);
                ConexionBD.InsertArticulo(tv2);
                ConexionBD.InsertArticulo(r1);
                ConexionBD.InsertArticulo(r2);
            }
            catch (ConexionDBException ex)
            {
                // Manejo excepciones en caso de que halla alguna
                Console.WriteLine(ex.Message);
            }

            // Traigo articulos de la BD 
            List<Articulo> articulos1 = ConexionBD.GetArticulos();
            // Traigo clientes de la BD
            List<Cliente> clientes1 = ConexionBD.GetClientes();

            if (articulos1 != null && clientes1 != null)
            {
                // Si los datos son distintos de null, entonces creo un nuevo negocio
                // y muestro los datos del mismo

                Negocio n2 = new Negocio(clientes1, articulos1, "negocio 2");
                Console.WriteLine(n2.MostrarDatosNegocio());
            }
            else
            {
                Console.WriteLine("Error al traer los datos de la BD");
            }

            Radio r4 = new Radio(1, "Radio samsung 2000", "Samsung", EEstado.Nuevo, 2000, 2);
            
            // Intento de modificar un articulo de la BD
            try
            {
                if (r4.ModificarArticuloEnBD(r2.NombreArticulo))
                {
                    Console.WriteLine("Articulo modificado con exito");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Intento de borrar un articulo de la BD
            try
            {
                if (ConexionBD.EliminarArticulo(tv1))
                {
                    Console.WriteLine("Articulo eliminado con exito");
                }
                else
                {
                    Console.WriteLine("No se encontro articulo para eliminar");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Intento de borrar un empleado de la BD
            try
            {
                if (ConexionBD.EliminarCliente(c2))
                {
                    Console.WriteLine("Cliente eliminado con exito");
                }
                else
                {
                    Console.WriteLine("No se encontro cliente para eliminar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            Console.Clear();
            // Tercer muestra: Archivos, creo archivos de tipo txt y xml, comprobando su correcto
            // funcionamiento.

            // Utilizo el metodo guardar, para guardar los datos de un negocio en formato txt
            // en el escritorio del usuario. Prevengo posibles excepciones
            try
            {
                if (n1.Guardar("DatosNegocios.txt", n1.MostrarDatosNegocio()))
                {
                    Console.WriteLine("Guardado con exito!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Compruebo el correcto guardado de los datos, leyendo el archivo
            // y mostrando los datos
            try
            {
                string datos;
                if (n1.Leer("DatosNegocios.txt", out datos))
                {
                    // muestro los datos
                    Console.WriteLine($"Muestro el archivo guardado: \n{datos}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Ahora pruebo guardar los datos de un articulo en forma xml y luego leerlos
            // para confirmar que se guardaron bien. 
            // Manejo de posibles excepciones

            try
            {
                if (Articulo.GuardarDatos("Radio1.xml", r1))
                {
                    Console.WriteLine("Datos guardados correctamente");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Trato de leer el mismo archivo para confirmar el correcto funcionamiento
            // de los metodos
            try
            {
                Radio auxRadio1; 
                if (Articulo.LeerDatos("Radio1.xml", out auxRadio1))
                {
                    Console.WriteLine($"Muestro el archivo guardado: \n{auxRadio1.ToString()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
