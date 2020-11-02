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
                try
                {
                    this.alumnos = value;
                }
                catch (NullReferenceException e)
                {
                    throw new NullReferenceException("Error al tratar de setear un valor nulo a la lista de instructores", e);
                }
                catch (Exception e)
                {
                    throw new ArgumentNullException("No se pudo cargar el listado de alumnos", e);
                }
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
                try
                {
                    this.clase = value;
                }

                catch (NullReferenceException e)
                {
                    throw new NullReferenceException("Error al tratar de setear un valor nulo a la lista de instructores", e);
                }
                catch (Exception e)
                {
                    throw new ArgumentNullException("No se pudo cargar el listado de clases", e);
                }
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
                try
                {
                    this.instructor = value;
                }
                catch (NullReferenceException e)
                {
                    throw new NullReferenceException("Error al tratar de setear un valor de tipo nulo", e);
                }
                catch (Exception e)
                {
                    throw new Exception("No se pudo cargar el listado de instructores", e);
                }
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, sirve para inicializar la lista de Alumnos
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
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
        /// <summary>
        /// Guarda una jornada en un archivo txt, llamado "Jornada.txt"
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns>True si el archivo fue guardado con exito, false caso contrario</returns>
        public static bool Guardar(Jornada jornada)
        {
            bool guardo;
            try
            {
                Texto archivo = new Texto();
                guardo = archivo.Guardar("Jornada.txt", jornada.ToString());
            }
            catch (ArgumentNullException e)
            {
                throw new ArchivosException("Error, no se pudo guardar el archivo txt. Error de referencia nula", e);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error, no se pudo guardar el archivo txt", e);
            }
            return guardo;
        }
        /// <summary>
        /// Se encarga de leer los datos del archivo denominado "Jornada.txt"
        /// </summary>
        /// <returns>True en el caso de haber leido el archivo con exito, false caso contrario</returns>
        public static string Leer()
        {
            string ret;
            bool checkRead;
            try
            {
                Texto archivo = new Texto();
                checkRead = archivo.Leer("Jornada.txt", out ret);
                return ret;
            }
            catch (ArgumentNullException e)
            {
                throw new ArchivosException("Error, no se pudo leer el archivo txt. Error de referencia nula", e);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error, no se pudo leer el archivo txt", e);
            }
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Muestra todos los datos de la jornada
        /// </summary>
        /// <returns>Los datos en forma de string</returns>
        public override string ToString()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("JORNADA");
                sb.AppendLine($"CLASE DE {this.Clase} - POR {this.Instructor.ToString()}");
                sb.Append("ALUMNOS: ");
                sb.AppendLine();
                if (this.Alumnos.Count > 0)
                {
                    foreach (Alumno auxAlumno in this.Alumnos)
                    {
                        sb.AppendLine($"{auxAlumno}");
                    }
                }
                else
                {
                    sb.AppendLine("No hay alumnos para esta jornada.");
                }
                sb.AppendLine("<---------------------------------------------------->");
                return sb.ToString();
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("Ocurrio un error al leer los datos", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error al leer los datos", e);
            }
        }
        /// <summary>
        /// Compara que un alumno pertenezca o no a una Jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>True si el alumno pertenece, false caso contrario</returns>
        public static bool operator ==(Jornada j, Alumno a) 
        {
            bool ret = false;
            try
            {
                foreach (Alumno auxAlumno in j.Alumnos)
                {
                    if (auxAlumno == a)
                    {
                        ret = true;
                    }
                }
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Error, instancia de jornada o de alumno es null", e);
            }
            return ret;
        }
        /// <summary>
        /// Compara que el alumno no pertenezca a una jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>True si no pertenece, false caso contrario</returns>
        public static bool operator !=(Jornada j, Alumno a) { return !(j == a); }
        /// <summary>
        /// Agrega a un alumno a una Jornada, solo si, este no pertenece a la misma
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>La jornada con el alumno agregado caso de exito, o una excepcion</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            try
            {
                if (j != a)
                {
                    j.Alumnos.Add(a);
                }
                return j;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Error, instancia de jornada o de alumno es null", e);
            }
        }
        #endregion
    }
}
