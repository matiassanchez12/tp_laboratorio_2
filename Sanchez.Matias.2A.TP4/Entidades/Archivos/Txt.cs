using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    /// <summary>
    /// Utilizo conocimiento sobre archivos txt
    /// </summary>
    public class Txt : IArchivo<string>
    {
        /// <summary>
        /// Constructor por defecto de texto
        /// </summary>
        public Txt()
        {

        }
        /// <summary>
        /// Guarda un archivo en formato txt con el nombre que va a ser pasado por parametros 
        /// y tambien recibe los datos para guardar por parametros
        /// Utilizo excepciones
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si se pudo cargar el archivo, caso contrario false</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool ret = false;

            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{archivo}.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(Path))
                {
                    writer.WriteLine(datos);
                    ret = true;
                }
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

            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{archivo}.txt";

            try
            {
                using (StreamReader reader = new StreamReader(Path, Encoding.UTF8))
                {
                    datos = reader.ReadToEnd();
                    ret = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException("Ocurrio un error, no se pudo leer el archivo", e);
            }
            return ret;
        }
    }
}
