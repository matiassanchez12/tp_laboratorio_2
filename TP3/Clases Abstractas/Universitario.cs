using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario:Persona
    {
        private int legajo;
        #region Constructores
        /// <summary>
        /// Constructor de universitario por defecto
        /// </summary>
        public Universitario()
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
        /// Metodo abstracto, sera utilizado en las clases hijas
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
            sb.AppendLine("Datos del universitario");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Legajo: {this.legajo}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static bool operator ==(Universitario pg1, Universitario pg2) 
        {
            bool ret = false;
            if(pg1.GetType() == pg2.GetType())
            {
                if (pg1.legajo == pg2.legajo && pg1.DNI == pg2.DNI)
                {
                    ret = true;
                }
            }
            return ret;
        }
        public static bool operator !=(Universitario pg1, Universitario pg2) { return !(pg1 == pg2); }

        #endregion

    }
}
