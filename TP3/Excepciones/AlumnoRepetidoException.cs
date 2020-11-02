using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException:Exception
    {
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje
        /// </summary>
        public AlumnoRepetidoException():base("Error, alumno repetido.")
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje personalizado
        /// </summary>
        public AlumnoRepetidoException(string message) : base(message)
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje y una innerExcepcion
        /// </summary>
        public AlumnoRepetidoException(string message, Exception innerException):base(message, innerException)
        {

        }
    }
}
