using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DelegadoNullException : Exception
    {
        /// <summary>
        /// Constructor por defecto, contiene un mensaje predeterminado
        /// </summary>
        public DelegadoNullException() : base("El delegado posee un valor de tipo null")
        {

        }
        /// <summary>
        /// Constructor parametrizado, recibe un mensaje personalizado
        /// </summary>
        /// <param name="msg">mensaje a mostrar</param>
        public DelegadoNullException(string msg) : base(msg)
        {

        }
        /// <summary>
        /// Constructor parametrizado, recibe un mensaje personalizado y recibe un excepcion
        /// </summary>
        /// <param name="msg">mensaje a mostrar</param>
        /// <param name="ex">excepcion</param>
        public DelegadoNullException(string msg, Exception ex) : base(msg, ex)
        {

        }
    }
}
