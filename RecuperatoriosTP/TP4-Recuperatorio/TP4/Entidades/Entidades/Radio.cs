using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Radio:Articulo
    {
        #region Atributos
        private int aniosDeAntiguedad;
        #endregion

        #region Constructores
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Radio() : base()
        {

        }
        /// <summary>
        /// Constructor parametrizado, reutiliza el constructor de la clase
        /// base
        /// </summary>
        /// <param name="idCliente">id del cliente</param>
        /// <param name="nombre">nombre de la radio</param>
        /// <param name="marca">marca de la radio</param>
        /// <param name="estado">estado de la radio</param>
        /// <param name="costo">costo de la radio</param>
        /// <param name="aniosDeAntiguedad">años de antiguedad de la radio</param>
        public Radio(int idCliente, string nombre, string marca, EEstado estado, double costo, int aniosDeAntiguedad)
            :base(idCliente, nombre, marca, estado, costo)
        {
            this.aniosDeAntiguedad = aniosDeAntiguedad;
        }
        #endregion

        #region Propiedades
        public int AniosDeAntiguedad { get => aniosDeAntiguedad; set => aniosDeAntiguedad = value; }
        #endregion

        #region Metodo
        /// <summary>
        /// Muestra todos los datos de la radio en forma de string
        /// reutilizando el metodo MostrarDatosArticulo de la clase base
        /// </summary>
        /// <returns>Los datos de la radio en forma de string</returns>
        protected override string MostrarDatosArticulo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatosArticulo());
            sb.AppendLine($"Años de antiguedad: {this.AniosDeAntiguedad} años");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga de toString, sirve para llamar al metodo
        /// mostrarDatosArticulo y exponer los datos de la radio
        /// </summary>
        /// <returns>Los datos de la radio en forma de string</returns>
        public override string ToString()
        {
            return this.MostrarDatosArticulo();
        }
        #endregion
    }
}
