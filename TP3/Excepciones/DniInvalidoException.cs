using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje
        /// /// </summary>
        public DniInvalidoException():base("Error, el DNI no es valido.")
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje personalizado
        /// </summary>
        public DniInvalidoException(string message) : base(message)
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje y una innerExcepcion
        /// </summary>
        public DniInvalidoException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
