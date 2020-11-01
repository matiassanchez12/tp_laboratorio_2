using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class DniInvalidoException:Exception
    {
        public DniInvalidoException():base("Error, DNI no es valido.")
        {

        }
        public DniInvalidoException(string message) : base(message)
        {

        }
        public DniInvalidoException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
