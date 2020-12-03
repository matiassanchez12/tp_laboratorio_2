using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public enum EEstado { Usado, Nuevo };
    public class Articulo : Xml<Articulo>
    {
        #region Atributos
        private int idClienteComprador;
        private string nombreArticulo;
        private string marca;
        private double costo;
        private EEstado estado;
        #endregion

        #region Propiedades
        public double Costo { get => costo; set => costo = value; }
        public int IdClienteComprador { get => idClienteComprador; set => idClienteComprador = value; }
        public string NombreArticulo { get => nombreArticulo; set => nombreArticulo = value; }
        public string Marca { get => marca; set => marca = value; }
        public EEstado EstadoArticulo { get => estado; set => estado = value; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Articulo()
        {

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="idClienteComprador">id del Cliente</param>
        /// <param name="nombreArticulo">nombre del articulo</param>
        /// <param name="marca">marca del articulo</param>
        /// <param name="estado">estado del articulo</param>
        /// <param name="costo">costo del articulo</param>
        protected Articulo(int idClienteComprador, string nombreArticulo, string marca, EEstado estado, double costo)
        {
            this.idClienteComprador = idClienteComprador;
            this.nombreArticulo = nombreArticulo;
            this.marca = marca;
            this.estado = estado;
            this.costo = costo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra todos los datos de un articulo
        /// </summary>
        /// <returns>Devuelve todos los datos en forma de string</returns>
        protected virtual string MostrarDatosArticulo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id cliente comprador: {this.IdClienteComprador}");
            sb.AppendLine($"Nombre del articulo: {this.NombreArticulo}");
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Estado: {this.EstadoArticulo}");
            sb.AppendLine($"Costo: $ {this.Costo}");
            return sb.ToString();
        }
        /// <summary>
        /// Guarda los datos en formato de Xml, en una ubicacion predeterminada
        /// </summary>
        /// <param name="archivo">Nombre del archivo que se va a crear</param>
        /// <param name="datos">Articulo con los datos a guardar</param>
        /// <returns>True si se pudo guardar bien, false caso contrario</returns>
        public static bool GuardarDatos(string archivo, Articulo datos)
        {
            bool ret = false;
            if (datos is Radio)
            {
                Xml<Radio> xmlCreator = new Xml<Radio>();
                if (xmlCreator.Guardar(archivo, (Radio)datos))
                {
                    ret = true;
                }
            }
            else
            {
                Xml<TV> xmlCreator = new Xml<TV>();
                if (xmlCreator.Guardar(archivo, (TV)datos))
                {
                    ret = true;
                }
            }
            return ret;
        }
        /// <summary>
        /// Lee los datos de tipo Radio en formato de Xml, de una ubicacion predeterminada
        /// </summary>
        /// <param name="archivo">Archivo de donde se van a leer los datos</param>
        /// <param name="datos">En donde se van a guardar los datos</param>
        /// <returns>True si se leyeron los datos correctamente, caso contrario false</returns>
        public static bool LeerDatos(string archivo, out Radio datos)
        {
            Xml<Radio> xmlCreator = new Xml<Radio>();
            return xmlCreator.Leer(archivo, out datos);
        }
        /// <summary>
        /// Lee los datos de tipo TV en formato de Xml, de una ubicacion predeterminada
        /// </summary>
        /// <param name="archivo">Archivo de donde se van a leer los datos</param>
        /// <param name="datos">En donde se van a guardar los datos</param>
        /// <returns>True si se leyeron los datos correctamente, caso contrario false</returns>
        public static bool LeerDatos(string archivo, out TV datos)
        {
            Xml<TV> xmlCreator = new Xml<TV>();
            return xmlCreator.Leer(archivo, out datos);
        }
        /// <summary>
        /// Metodo que sirve para generar un ticket de un articulo.
        /// El ticket incluye la hora actual de emicion y todos los datos del
        /// articulo
        /// </summary>
        /// <param name="datos">Articulo de donde se leer los datos</param>
        /// <returns>True si genera el ticket con exito, false caso contrario</returns>
        public static bool GenerarTicket(Articulo datos)
        {
            bool ret = false;

            Txt txtCreator = new Txt();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Hora de emicion: {DateTime.Now.ToString("dd/MM/yy HH:mm:ss")}");
            sb.AppendLine();
            sb.AppendLine(datos.ToString());

            if(txtCreator.Guardar("TicketCliente", sb.ToString()))
            {
                ret = true;
            }

            return ret;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga de to string, sirve para mostrar los datos llamando
        /// al metodo correspondiente
        /// </summary>
        /// <returns>Los datos de tipo string que devuelve el metodo llamado</returns>
        public override string ToString()
        {
            return this.MostrarDatosArticulo();
        }
        #endregion
    }
}
