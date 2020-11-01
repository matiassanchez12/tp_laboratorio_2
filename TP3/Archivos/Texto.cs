﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto:IArchivo<string>
    {
        public Texto()
        {

        }
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
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return ret;
        }
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
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return ret;
        }
    }
}
