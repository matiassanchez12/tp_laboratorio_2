using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
        public SinProfesorException():base("No se ingreso un profesor para la clase")
        {

        }
        public SinProfesorException(string message) : base(message)
        {

        }
        public SinProfesorException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
