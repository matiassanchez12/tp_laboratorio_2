using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje
        /// </summary>
        public SinProfesorException():base("No hay profesor para la clase.")
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje personalizado
        /// </summary>
        public SinProfesorException(string message) : base(message)
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje y una innerExcepcion
        /// </summary>
        public SinProfesorException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
