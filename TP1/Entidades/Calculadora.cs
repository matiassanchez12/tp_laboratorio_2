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
        #region Metodos
        /// <summary>
        /// Realiza una operacion matematica entre dos numeros
        /// </summary>
        /// <param name="num1">Primer numero</param>
        /// <param name="num2">Segundo numero</param>
        /// <param name="operador">Operador de la cuenta</param>
        /// <returns>El resultado de la operacion</returns>
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
        /// <summary>
        /// Recibe un operador y valida que sea efectivamente un operador
        /// </summary>
        /// <param name="operador">Operador a ser verificado</param>
        /// <returns>Devuelve un operador matematico designado por el usuario o el operador "+"</returns>
        private static string ValidarOperador(string operador)
        {
            string ret = "+";
            if(String.Equals(operador, "+") == true || String.Equals(operador, "-") == true || String.Equals(operador, "*") == true || String.Equals(operador, "/") == true)
            {
                ret = operador;
            }
            return ret;
        }
        #endregion
    }
}
