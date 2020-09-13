using System;

namespace pruebas
{

    class Program
    {
        static void Main(string[] args)
        {
            string miNum = "123";
            double newValue = 0;
            bool isNumber = double.TryParse(miNum, out newValue);
            if(isNumber == true)
            {
                Console.WriteLine("bool : {0} - value : {1}", isNumber, newValue);
            }
            else
            {
                Console.WriteLine("No es un numero.");
            }
        }
        private static double ValidarNumero(string strNumero)
        {
            double newValue = 0;
            bool isNumber = double.TryParse(strNumero, out newValue);
            return newValue;
        }
    }
}
