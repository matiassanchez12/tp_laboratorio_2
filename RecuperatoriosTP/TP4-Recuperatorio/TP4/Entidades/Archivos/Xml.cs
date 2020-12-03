using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    /// Utilizo conocimiento sobre archivos Xml
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Constructor por defecto de Xml
        /// </summary>
        public Xml()
        {

        }
        /// <summary>
        /// Guarda un archivo en formato Xml, recibiendo como parametros un string con el nombre
        /// del archivo y el otro parametro son los datos de tipo generico a ser guardados
        /// Utilizo Tipos genericos
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true en caso de que se puso guardar con exito, caso contrario false</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool ret = false;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{archivo}.xml";
            try
            {
                using (XmlTextWriter textWriter = new XmlTextWriter(Path, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(textWriter, datos);
                    ret = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException("Ocurrio un error y no se pudo guardar el archivo", e);
            }
            return ret;
        }
        /// <summary>
        /// Se encarga de leer un archivo de tipo xml, recibiendo un string con el nombre
        /// de este archivo y ademas un dato de tipo generico que es donde se guardaran los datos
        /// que el metodo pudo leer del archivo encontrado
        /// Utilizo Tipos genericos
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si pudo leer correctamente, false caso contrario</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool ret = false;

            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{archivo}.xml";
            
            try
            {
                using (XmlTextReader textReader = new XmlTextReader(Path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    
                    datos = (T)serializer.Deserialize(textReader);
                    
                    ret = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException("Ocurrio un error y no se pudo leer el archivo", e);
            }
            return ret;
        }
        }
}
