using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public enum EMedioDePago
    {
        SinDatos,
        Efectivo,
        Debito,
        Credito,
        MercadoPago,
        Otro
    }
    public class Cliente
    {
        #region Atributos

        private int id;
        private string nombre;
        private string dni;
        EMedioDePago formaPago;
        private char sexo;

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Cliente()
        {

        }
        /// <summary>
        /// Constructor parametrizado, setea varios valores
        /// </summary>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="dni">dni del cliente</param>
        /// <param name="formaPago">forma de pago del cliente</param>
        /// <param name="sexo">sexo del cliente</param>
        public Cliente(string nombre, string dni, EMedioDePago formaPago, char sexo)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.FormaPago = formaPago;
            this.Sexo = sexo;
        }
        /// <summary>
        /// Constructor parametrizado, incluye el id del cliente y reutiliza
        /// el otro constructor
        /// </summary>
        /// <param name="id">id del cliente</param>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="dni">dni del cliente</param>
        /// <param name="formaPago">forma de pago del cliente</param>
        /// <param name="sexo">sexo del cliente</param>
        public Cliente(int id, string nombre, string dni, EMedioDePago formaPago, char sexo):this(nombre, dni, formaPago, sexo)
        {
            this.Id = id;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = this.ValidarNombre(value); }
        public string Dni { get => dni; set => dni = this.ValidarDni(value); }
        public EMedioDePago FormaPago { get => formaPago; set => formaPago = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        #endregion

        #region Metodo
        /// <summary>
        /// Muestra todos los datos del cliente
        /// </summary>
        /// <returns>Los datos en forma de string</returns>
        private string MostrarDatosCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id del cliente: {this.Id}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Sexo: {this.Sexo}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Forma de pago: {this.FormaPago}");
            return sb.ToString();
        }
        /// <summary>
        /// Valida que la cadena pasada por parametros, sea un string
        /// caso contrario devuelve la cadena vacia y se crea una excepcion.
        /// </summary>
        /// <param name="dato">cadena a verificar</param>
        /// <returns></returns>
        private string ValidarNombre(string dato)
        {
            string validString = "";

            if (Regex.IsMatch(dato, @"[a-zA-ZñÑ\s]"))
            {
                validString = dato;
            }
            else
            {
                throw new NombreInvalidoException();
            }
            return validString;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametros sea un dni
        /// </summary>
        /// <param name="dato">cadena a verificar</param>
        /// <returns></returns>
        private string ValidarDni(string dato)
        {
            try
            {
                dato = dato.Replace("-", "");

                if (dato.Length != 8)
                {
                    throw new DNIInvalidoException("Error, el dni ingresado es menor a 8 digitos o contiene caracteres invalidos.");
                }
                // Compruebo de que el string sea un numero
                Int32.Parse(dato);
            }
            catch (Exception e)
            {
                throw new DNIInvalidoException(e.Message);
            }

            return dato;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// sobrecarga de to string, sirve para mostrar los datos
        /// mediante el metodo correspondiente
        /// </summary>
        /// <returns>Devuelve un string con todos los datos</returns>
        public override string ToString()
        {
            return this.MostrarDatosCliente();
        }
        #endregion
    }
}
