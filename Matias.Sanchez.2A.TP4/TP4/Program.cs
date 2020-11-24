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
            Negocio n1 = new Negocio("Algo");

            Artefactos artefactos = new Artefactos();
            Articulo a1 = new Articulo("Tostadora", 22, Articulo.Tipo.Otro, "-");
            Articulo a2 = new Articulo("Lavadora", 23, Articulo.Tipo.Otro, "-");
            Articulo a3 = new Articulo("Lava2", 24, Articulo.Tipo.Heladera, "Algo");

            artefactos += a1;
            artefactos += a2;
            artefactos += a3;

            //Console.WriteLine(artefactos);

            try
            {
                Empleado e1 = new Empleado("Dario", "Julian", "Rodrigo 123", "123212", "15555511", 1);
                Empleado e2 = new Empleado("Jose", "WWW", "Rodrigo 2222", "3333333", "12121212", 2);

                //Console.WriteLine(e1.ToString());
                Cliente c1 = new Cliente(artefactos, "Jorge", "asdasd", "-", "12312", "12312", 1, Cliente.TipoCliente.Conocido);
                Cliente c2 = new Cliente(artefactos, "Juan", "FFF", "SSS", "11111", "222222", 2, Cliente.TipoCliente.Conocido);
                //Console.WriteLine(c1.ToString());

                n1 += e1;
                n1 += e2;
                n1 += c1;
                n1 += c2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(n1.ToString());

            Console.ReadKey();

        }
    }
}
