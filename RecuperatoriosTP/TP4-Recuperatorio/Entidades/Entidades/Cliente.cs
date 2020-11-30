using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.nombre = nombre;
            this.dni = dni;
            this.formaPago = formaPago;
            this.sexo = sexo;
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
            this.id = id;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
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
