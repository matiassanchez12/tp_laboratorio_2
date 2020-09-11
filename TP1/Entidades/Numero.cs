using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        //ATTRIBUTES
        public double numero;
        //CONSTRUCTORS
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            this.numero = Convert.ToDouble(strNumero);
        }
        //PROPIERTIES
        public string SetNumero
        {
            set {
                numero = ValidarNumero(value);
                }
        }

        //METHODS
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario) == true)
            {
                int unString = Convert.ToInt32(binario, 2);
                return Convert.ToString(unString);
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Convierte de decimal a binario recibiendo un string
        /// </summary>
        /// <param name="numero">Numero a convertir en binario</param>
        /// <returns>Retorna el binario correspondiente, caso contrario "Valor invalido"</returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "";
            if (double.TryParse(numero, out double valor))
            {
                retorno = DecimalBinario(valor);
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }
        public string DecimalBinario(double numero)
        {
            int valueInt = (int)Math.Round(numero);
            string binary = Convert.ToString(valueInt, 2);
            return binary;
        }
        private bool EsBinario(string binario)
        {
            foreach (var c in binario)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        private double ValidarNumero(string strNumero)
        {
            double newValue = 0;
            bool isNumber = double.TryParse(strNumero, out newValue);
            return newValue;
        }

        //OPERATORS OVERLOAD
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero; 
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double ret = double.MinValue;
            if (n2.numero != 0)
            {
                ret = n1.numero / n2.numero;
            }
            return ret;
        }

    }
}
