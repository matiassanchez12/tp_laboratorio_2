using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConexionDBException : Exception
    {
        /// <summary>
        /// Constructor por defecto con Mensaje de excepcion estandar 
        /// </summary>
        public ConexionDBException() : base("Ocurrio un error al operar con la base de datos")
        {

        }
        /// <summary>
        /// Constructor por parametrizado con Mensaje de excepcion personalizado
        /// </summary>
        /// <param name="msg"></param>
        public ConexionDBException(string msg) : base(msg)
        {

        }
        /// <summary>
        /// Constructor por parametrizado con Mensaje de excepcion personalizado y
        /// tambien recibe una excepcion
        /// </summary>
        /// <param name="msg">mensaje</param>
        /// <param name="ex">excepcion capturada</param>
        public ConexionDBException(string msg, Exception ex) : base(msg, ex)
        {

        }
    }
}
