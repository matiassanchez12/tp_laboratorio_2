using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje
        /// </summary>
        public NacionalidadInvalidaException():base("La nacionalidad no se condice con el numero de DNI")
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje personalizado
        /// </summary>
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }
        /// <summary>
        /// Este Constructor reutiliza el constructor de la clase base, pasandole un mensaje y una innerExcepcion
        /// </summary>
        public NacionalidadInvalidaException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
