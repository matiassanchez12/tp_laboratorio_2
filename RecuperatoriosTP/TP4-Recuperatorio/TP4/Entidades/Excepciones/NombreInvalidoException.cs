using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class NombreInvalidoException : Exception
    {
        /// <summary>
        /// Constructor por defecto, con un mensaje predeterminado
        /// </summary>
        public NombreInvalidoException() : base("Error, el nombre ingresado no es valido")
        {

        }
        /// <summary>
        /// constructor parametrizado, recibe un mensaje personalizado
        /// </summary>
        /// <param name="msg">mensaje</param>
        public NombreInvalidoException(string msg) : base(msg)
        {

        }
    }
}
