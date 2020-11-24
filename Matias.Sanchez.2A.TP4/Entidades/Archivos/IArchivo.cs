using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Metodo guardar de una clase de tipo interface, recibe su funcionalidad 
        /// en las clases que utilicen esta interface
        /// </summary>
        /// <param name="archivo">El nombre del archivo donde se van a guardar los datos</param>
        /// <param name="datos">Los datos</param>
        /// <returns>True o false</returns>
        bool Guardar(string archivo, T datos);
        /// <summary>
        /// Metodo Leer de una clase de tipo interface, recibe su funcionalidad en las clases que utilicen esta interface
        /// </summary>
        /// <param name="archivo">El nombre del archivo de donde se van a leer los datos</param>
        /// <param name="datos">En donde se van a guardar esos datos</param>
        /// <returns>True o false</returns>
        bool Leer(string archivo, out T datos);
    }
}
