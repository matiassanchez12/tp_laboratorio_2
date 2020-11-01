using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException:Exception
    {
        public AlumnoRepetidoException():base("El alumno ingresado ya fue ingresado anteriormente")
        {

        }
        public AlumnoRepetidoException(string message) : base(message)
        {

        }
        public AlumnoRepetidoException(string message, Exception innerException):base(message, innerException)
        {

        }
    }
}
