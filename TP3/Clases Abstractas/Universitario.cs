using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario:Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de universitario por defecto
        /// </summary>
        public Universitario():base()
        {

        }
        /// <summary>
        /// Constructor parametrizado, inicializa atributos
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo abstracto, sera utilizado en las clases que heredan esta clase
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();
        /// <summary>
        /// Muestra todos los datos del Universitario
        /// </summary>
        /// <returns>Los datos</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"LEGAJO NUMERO: {this.legajo}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del metodo equals, que compara un dato de tipo object con
        /// la instancia que llamo al metodo.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si object y la instancia son iguales, caso contrario False</returns>
        public override bool Equals(object obj)
        {
            return this == (Universitario)obj;
        }
        /// <summary>
        /// Sobrecarga de igual igual, comprueba que si el legajo y el DNI de dos
        /// universitarios son iguales, entonces son la misma Persona.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>True si son iguales, caso contrario False</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2) 
        {
            bool ret = false;
            try
            {
                if (pg1.GetType() == pg2.GetType())
                {
                    if (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI)
                    {
                        ret = true;
                    }
                }
                return ret;
            }
            catch(NullReferenceException e)
            {
                throw new NullReferenceException("Alguna de las referencias pasadas por parametros es null", e);
            }
        }
        /// <summary>
        /// Compara dos universitarios y comprueba que sean distintos
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>True si son distintos, false si son iguales</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2) { return !(pg1 == pg2); }

        #endregion

    }
}
