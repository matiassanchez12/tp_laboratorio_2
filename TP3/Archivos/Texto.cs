using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Constructor por defecto de texto
        /// </summary>
        public Texto()
        {

        }
        /// <summary>
        /// Guarda un archivo en formato txt con el nombre que va a ser pasado por parametros 
        /// y tambien recibe los datos para guardar por parametros
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si se pudo cargar el archivo, caso contrario false</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool ret = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    writer.WriteLine(datos);
                    ret = true;
                }
            }
            catch (ArgumentNullException e)
            {
                throw new ArchivosException("Error, Uno de los parametros pasados es null", e);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Ocurrio un error, no se pudo guardar el archivo", e);
            }
            return ret;
        }
        /// <summary>
        /// Leer un archivo en formato txt recibiendo como parametros el nombre del mismo y los el string en donde
        /// se van a guardar los datos
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si pudo leer el archivo, false caso contrario</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool ret = false;
            try
            {
                using (StreamReader reader = new StreamReader(archivo, Encoding.UTF8))
                {
                    datos = reader.ReadToEnd();
                    ret = true;
                }
            }
            catch (ArgumentNullException e)
            {
                throw new ArchivosException("Error, Uno de los parametros pasados es null", e);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Ocurrio un error, no se pudo leer el archivo", e);
            }
            return ret;
        }
    }
}

