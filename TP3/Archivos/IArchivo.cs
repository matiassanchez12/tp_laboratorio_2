using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Metodo guardar de tipo interface, es decir, va a recibir su funcionalidad en las clases que utilicen esta interface
        /// </summary>
        /// <param name="archivo">El nombre del archivo donde se van a guardar los datos</param>
        /// <param name="datos">Los datos</param>
        /// <returns>Un dato de tipo boolean</returns>
        bool Guardar(string archivo, T datos);
        /// <summary>
        /// Metodo Leer de tipo interface, es decir, va a recibir su funcionalidad en las clases que utilicen esta interface
        /// </summary>
        /// <param name="archivo">El nombre del archivo de donde se van a leer los datos</param>
        /// <param name="datos">En donde se van a guardar esos datos</param>
        /// <returns>Un dato de tipo boolean</returns>
        bool Leer(string archivo, out T datos);
    }
}
