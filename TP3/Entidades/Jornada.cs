using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, sirve para inicializar la lista de Alumnos
        /// </summary>
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Constructor parametrizado, inicializa atributos de Jornada y ademas
        /// la lista de Alumnos mediante la reutilizacion del constructor por defecto
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region Metodos
        public static bool Guardar(Jornada jornada)
        {
            bool guardo;
            try
            {
                Texto archivo = new Texto();
                guardo = archivo.Guardar("Jornada.txt", jornada.ToString());
            }
            catch(Exception e)
            {
                throw new ArchivosException("Error, no se pudo guardar el archivo txt", e);
            }
            return guardo;
        }
        public static string Leer()
        {
            string ret = "";
            bool read;
            try
            {
                Texto archivo = new Texto();
                read = archivo.Guardar("Jornada.txt", ret);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error, no se pudo leer el archivo txt", e);
            }
            return ret;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Clase: {this.Clase} - Instructor: {this.Instructor}");
            sb.AppendLine("Alumnos");
            foreach (Alumno auxAlumno in this.Alumnos)
            {
                sb.AppendLine($"{auxAlumno}");
            }
            return base.ToString();
        }
        public static bool operator ==(Jornada j, Alumno a) 
        {
            bool ret = false;
            foreach (Alumno auxAlumno in j.Alumnos)
            {
                if(auxAlumno == a)
                {
                    ret = true;
                }
            }
            return ret;
        }
        public static bool operator !=(Jornada j, Alumno a) { return !(j == a); }
        public static bool operator +(Jornada j, Alumno a)
        {
            bool ret = false;
            if(j != a)
            {
                ret = true;
                j.Alumnos.Add(a);
            }
            return ret;
        }
        #endregion
    }
}
