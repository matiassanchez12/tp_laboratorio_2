using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException():base("La nacionalidad ingresada es invalida")
        {

        }
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }
        public NacionalidadInvalidaException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
