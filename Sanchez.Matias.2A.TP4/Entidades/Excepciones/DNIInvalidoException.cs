using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class DNIInvalidoException : Exception
    {
        /// <summary>
        /// Constructor por defecto, con un mensaje predeterminado
        /// </summary>
        public DNIInvalidoException() : base("Error, el DNI ingresado no es valido")
        {

        }
        /// <summary>
        /// constructor parametrizado, recibe un mensaje personalizado
        /// </summary>
        /// <param name="msg">mensaje</param>
        public DNIInvalidoException(string msg) : base(msg)
        {

        }
    }
}
