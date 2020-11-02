using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno:Universitario
    {
        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        public enum EEstadoCuenta { AlDia, Deudor, Becado };
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, reutiliza el constructor base por defecto
        /// </summary>
        public Alumno() :base()
        {

        }
        /// <summary>
        /// Constructor parametrizado, inicializa la mayoria de los atributos reutilizando el constructor base
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor parametrizado, reutiliza el otro constructor parametrizado, ademas inicializa el atributo estadoCuenta 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos de un alumno
        /// </summary>
        /// <returns>Los datos del alumno en forma de string</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"ESTADO DE CUENTA: { Enum.GetName(typeof(EEstadoCuenta), this.estadoCuenta).ToString()}");
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// Devuelve la clase que toma un alumno en forma de string
        /// </summary>
        /// <returns>La clase en forma de string</returns>
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE " + this.claseQueToma;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga de tostring, sirve para mostrar los datos con el metodo mostrarDatos
        /// </summary>
        /// <returns>Los datos en forma de string</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Compara un alumno con una clase, comprobando que la clase que toma el alumno sea
        /// igual a la clase y que el estado de cuenta sea distinto a deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>True si el alumno toma la clase, false caso contrario</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool ret = false;
            try
            {
                if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
                {
                    ret = true;
                }
            }
            catch(NullReferenceException e)
            {
                throw new NullReferenceException("Referencia a instancia pasada por parametro de Alumno, es nula", e);
            }
            return ret;
        }
        /// <summary>
        /// Comprueba que un alumno, NO tome una clase determinada
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>True si el alumno no toma la clase, false si la toma</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase) { return !(a == clase); }

        #endregion
    }
}
