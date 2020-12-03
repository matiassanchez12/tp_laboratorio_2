using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TV:Articulo
    {
        #region Atributos

        private double peso;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public TV():base()
        {

        }
        /// <summary>
        /// Constructor parametrizado, reutiliza constructor
        /// de la clase base
        /// </summary>
        /// <param name="idClienteComprador">id del cliente que lo compro</param>
        /// <param name="nombreArticulo">nombre de la tv</param>
        /// <param name="marca">marca de la tv</param>
        /// <param name="estado">estado de la tv</param>
        /// <param name="peso">peso de la tv</param>
        /// <param name="costo">costo de la tv</param>
        public TV(int idClienteComprador, string nombreArticulo, string marca, EEstado estado,double peso, double costo)
            :base(idClienteComprador, nombreArticulo, marca, estado, costo)
        {
            this.peso = peso;
        }
        #endregion
        
        #region Propiedades
        public double Peso { get => peso; set => peso = value; }
        #endregion

        #region Metodos
        /// <summary>
        /// Llama al metodo de la clase base con el mismo nombre
        /// y muestra todos los datos de una tv en formato de string
        /// </summary>
        /// <returns>Los datos en formato de string</returns>
        protected override string MostrarDatosArticulo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatosArticulo());
            sb.AppendLine($"Peso del TV: {this.Peso} kg.");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga de toString, sirve para mostrar
        /// los datos obtenidos del metodo MostrarDatosArticulo
        /// </summary>
        /// <returns>Los datos obtenidos en formato de string</returns>
        public override string ToString()
        {
            return this.MostrarDatosArticulo();
        }
        #endregion
    }
}
