using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio : Txt
    {
        /// <summary>
        /// Evento que se utilizara para generar un ticket, osea un archivo txt en el escritorio
        /// </summary>
        public static event DelegadoGenerarTicket generarTicket;

        #region Atributos
        private string nombreNegocio;
        private List<Cliente> clientes;
        private List<Articulo> articulos;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        static Negocio()
        {
            generarTicket += Articulo.GenerarTicket;
        }
        /// <summary>
        /// constructor parametrizado, inicializa las listas 
        /// clientes y articulos, ademas del nombre
        /// </summary>
        /// <param name="nombre">nombre del negocio</param>
        public Negocio(string nombre)
        {
            this.Nombre = nombre;
            this.Clientes = new List<Cliente>();
            this.Articulos = new List<Articulo>();
        }
        /// <summary>
        /// constructor parametrizado, inicializa las listas 
        /// clientes y articulos, ademas del nombre
        /// </summary>
        /// <param name="clientes">lista de clientes</param>
        /// <param name="articulos">lista de articulos</param>
        /// <param name="nombre">nombre del negocio</param>
        public Negocio(List<Cliente> clientes, List<Articulo> articulos, string nombre)
        {
            this.Nombre = nombre;
            this.Clientes = clientes;
            this.Articulos = articulos;
        }
        #endregion

        #region Propiedades
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public List<Articulo> Articulos { get => articulos; set => articulos = value; }
        public string Nombre { get => nombreNegocio; set => nombreNegocio = value; }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos del negocio, junto con todos los clientes 
        /// y cada cliente con todos sus articulos
        /// </summary>
        /// <returns>Los datos en forma de string</returns>
        public string MostrarDatosNegocio()
        {
            int count = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del negocio: {this.Nombre}");
            sb.AppendLine();
            sb.AppendLine("               CLIENTES DEL NEGOCIO ");
            sb.AppendLine("------------------------------------------------------------");
            foreach (Cliente auxCliente in this.Clientes)
            {
                sb.AppendLine(auxCliente.ToString());
                sb.AppendLine("-- ARTICULOS COMPRADOS POR EL CLIENTE --");
                foreach (Articulo auxArticulos in this.Articulos)
                {
                    if(auxCliente.Id == auxArticulos.IdClienteComprador)
                    {
                        count++;
                        sb.AppendLine(auxArticulos.ToString());
                    }
                }
                if (count == 0)
                {
                    sb.AppendLine("\nEste cliente no cuenta con ninguna compra.\n");
                }
                count = 0;
                sb.AppendLine("------------------------------------------------------------");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Guarda todos los datos de un negocio en formato txt
        /// </summary>
        /// <param name="archivo">Nombre del archivo txt</param>
        /// <param name="datos">Instancia del negocio</param>
        /// <returns>True si se guardo con exito, false caso contrario</returns>
        public static bool GuardarDatosTxt(string archivo, Negocio datos)
        {
            bool ret = false;
            
            Txt txtCreator = new Txt();
           
            if(txtCreator.Guardar(archivo, datos.MostrarDatosNegocio()))
            {
                ret = true;
            }

            return ret;
        } 
        /// <summary>
        /// Leer datos de un archivo determinado del tipo txt
        /// </summary>
        /// <param name="archivo">Nombre del archivo</param>
        /// <param name="datos"> Donde se guardaran los datos</param>
        /// <returns>True si se trayeron los datos con exito, false caso contrario</returns>
        public static bool LeerDatosTxt(string archivo, out string datos)
        {
            bool ret = false;

            Txt txtCreator = new Txt();

            if(txtCreator.Leer(archivo, out datos))
            {
                ret = true;
            }

            return ret;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Verificado que un cliente exista en un negocio, comparando el dni del cliente
        /// </summary>
        /// <param name="n">Instancia de negocio</param>
        /// <param name="c">Instancia de cliente</param>
        /// <returns>True si el cliente ya existe, false caso contrario</returns>
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente auxCliente in n.Clientes)
            {
                if(auxCliente.Dni == c.Dni)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Se reutiliza el == para saber si el cliente no existe
        /// </summary>
        /// <param name="n">Instancia de negocio</param>
        /// <param name="c">Instancia de cliente</param>
        /// <returns>True si el cliente no existe, false caso contrario</returns>
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        /// <summary>
        /// Se agrega un cliente al negocio, solo si este no esta agregado
        /// </summary>
        /// <param name="n">Instancia de negocio</param>
        /// <param name="c">Instancia de cliente</param>
        /// <returns>Negocio con el cliente agregado o el negocio sin ninguna modificacion</returns>
        public static Negocio operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.Clientes.Add(c);
            }
            return n;
        }
        /// <summary>
        /// Comprueba que el articulo exista en la lista de articulos del negocio
        /// comparando el nombre y el estado con los demas articulos
        /// </summary>
        /// <param name="n">Instancia de negocio</param>
        /// <param name="a">Instancia de articulo</param>
        /// <returns>True si el articulo existe, false caso contrario</returns>
        public static bool operator ==(Negocio n, Articulo a)
        {
            foreach (Articulo auxArtefacto in n.Articulos)
            {
                if(auxArtefacto.NombreArticulo == a.NombreArticulo && auxArtefacto.EstadoArticulo == a.EstadoArticulo)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Reutilizando el == se comprueba que un articulo no exista en 
        /// un negocio
        /// </summary>
        /// <param name="n">Instancia de negocio</param>
        /// <param name="a">Instancia de articulo</param>
        /// /// <returns>True si el articulo no existe, false caso contrario</returns>
        public static bool operator !=(Negocio n, Articulo a)
        {
            return !(n == a);
        }
        /// <summary>
        /// Agrega un articulo a la lista de articulos del negocio y ademas 
        /// genera un ticket mediante la invocacion del evento generarTicket
        /// Utilizo eventos
        /// </summary>
        /// <param name="n">Instancia de negocio</param>
        /// <param name="a">Instancia de articulo</param>
        /// <returns>True si se agrego correctamente, false caso contrario</returns>
        public static Negocio operator +(Negocio n, Articulo a)
        {
            if(n != a)
            {
                n.Articulos.Add(a);

                generarTicket.Invoke(a);
            }
            return n;
        }
        #endregion

    }
}
