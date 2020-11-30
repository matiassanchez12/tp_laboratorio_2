using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivosException:Exception
    {
        /// <summary>
        /// Constructor por defecto, contiene un mensaje predeterminado
        /// </summary>
        public ArchivosException() : base("Error, el archivo no se pudo leer o escribir el archivo.")
        {

        }
        /// <summary>
        /// Constructor parametrizado, recibe un mensaje personalizado y una excepcion
        /// </summary>
        /// <param name="msg">Mensaje</param>
        /// <param name="ex">Excepcion</param>
        public ArchivosException(string msg, Exception ex) : base(msg, ex)
        {

        }
    }
}
