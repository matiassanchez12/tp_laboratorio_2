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
                throw new ArchivosException(e);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return ret;
        }
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
                throw new ArchivosException(e);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return ret;
        }
    }
}
