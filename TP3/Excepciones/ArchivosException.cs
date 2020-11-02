using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException:Exception
    {
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje
        /// </summary>
        public ArchivosException():base("Error, no se pudo leer o escribir el archivo")
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje personalizado
        /// </summary>
        public ArchivosException(string message) : base(message)
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje y una innerExcepcion
        /// </summary>
        public ArchivosException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
