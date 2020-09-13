using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public double Operar(Numero num1, Numero num2, string operador)
        {
            double ret = 0;
            string validOperator = ValidarOperador(operador);
            switch (validOperator)
            {
                case "+":
                    ret = num1 + num2;
                    break;
                case "-":
                    ret = num1 - num2;
                    break;
                case "*":
                    ret = num1 * num2;
                    break;
                case "/":
                    ret = num1 / num2;
                    break;
            }
            return ret;
        }

        private static string ValidarOperador(string operador)
        {
            string ret = "+";
            if(String.Equals(operador, "+") == true || String.Equals(operador, "-") == true || String.Equals(operador, "*") == true || String.Equals(operador, "/") == true)
            {
                ret = operador;
            }
            return ret;
        } 
    }
}
