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
        #region Atributos
        public double numero;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Numero()
        {
            this.SetNumero = Convert.ToString(0);
        }
        /// <summary>
        /// Constructor parametrizado, se encarga de darle un valor tipo double al atributo numero
        /// </summary>
        /// <param name="numero">Recibe el valor de numero</param>
        public Numero(double numero)
        {
            this.SetNumero = numero.ToString();
        }
        /// <summary>
        /// Constructor parametrizado, se encarga de darle un valor tipo string al atributo numero
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        //PROPIERTIES
        /// <summary>
        /// SetNumero es el encargado de validar antes de cargar un valor en el atributo numero
        /// </summary>
        public string SetNumero
        {
            set {
                numero = ValidarNumero(value);
                }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Convierte un numero binario a decimal, verificando que sea binario, caso contrario devuelve un mensaje
        /// </summary>
        /// <param name="binario">Numero binario a convertir</param>
        /// <returns>Devuelve un numero binario o un mensaje de error</returns>
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
        /// <returns>Retorna un numero binario, caso contrario un mensaje de error</returns>
        public string DecimalBinario(string numero)
        {
            string retorno;
            if (double.TryParse(numero, out double valor))
            {
                retorno = DecimalBinario(valor);
            }
            else
            {
                retorno = "Valor inválido";
            }
            return retorno;
        }
        /// <summary>
        /// Convierte de decimal a binario recibiendo un double
        /// </summary>
        /// <param name="numero">Numero a convertir en binario</param>
        /// <returns>Retorna un numero binario, caso contrario un mensaje de error</returns>
        public string DecimalBinario(double numero)
        {
            string ret;
            if (numero >= 0)
            {
                int valueInt = (int)Math.Round(numero);
                ret = Convert.ToString(valueInt, 2);
            }
            else
            {
                ret = "Valor inválido";
            }
           
            return ret;
        }
        /// <summary>
        /// Verifica que un dato tipo string sea binario
        /// </summary>
        /// <param name="binario">El dato a verificar</param>
        /// <returns>Devuelve true en caso de que sea binario, caso de error: false </returns>
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
        /// <summary>
        /// Recibe un dato de tipo string y valida sea un numero
        /// </summary>
        /// <param name="strNumero">String a verificar</param>
        /// <returns>Si strNumero es un numero, lo convierte a double y lo devuelve, caso contrario retorna 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double ret;
            if(double.TryParse(strNumero, out double newValue) == true)
            {
                ret = newValue;
            }
            else
            {
                ret = 0;
            }
            return ret;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Resta entre dos atributos de la clase Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>El resultado de la operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Suma entre dos atributos de la clase Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>El resultado de la operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero; 
        }
        /// <summary>
        /// Multiplicacion entre dos atributos de la clase Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>El resultado de la operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Division entre dos atributos de la clase Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>El resultado de la operacion</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double ret = double.MinValue;
            if (n2.numero != 0)
            {
                ret = n1.numero / n2.numero;
            }
            return ret;
        }
        #endregion
    }
}
