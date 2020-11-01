using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Guarda un archivo en formato Xml, recibiendo como parametros un string con el nombre
        /// del archivo y el otro parametros son los datos a ser guardados
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true en caso de que se puso guardar con exito, caso contrario false</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool ret = false;
            try
            {
                using (XmlTextWriter textWriter = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(textWriter, datos);
                    ret = true;
                }
            }
            catch (InvalidOperationException e)
            {
                throw new ArchivosException("Ocurrio un error, no se pudo guardar el archivo", e);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Ocurrio un error, no se pudo guardar el archivo", e);
            }
            return ret;
        }
        /// <summary>
        /// Se encarga de leer un archivo de tipo xml, recibiendo un string con el nombre
        /// de este archivo y ademas un dato de tipo generico que es donde se guardaran los datos
        /// que el metodo pudo leer
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si pudo leer correctamente, false caso contrario</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool ret = false;
            try
            {
                using (XmlTextReader textReader = new XmlTextReader(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datos = (T)serializer.Deserialize(textReader);
                    ret = true;
                }
            }
            catch (InvalidOperationException e)
            {
                throw new ArchivosException("Ocurrio un error, no se pudo guardar el archivo", e);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Ocurrio un error, no se pudo guardar el archivo", e);
            }
            return ret;
        }
    }
}
