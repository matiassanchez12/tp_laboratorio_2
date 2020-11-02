using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using Archivos;
using System.Xml;
using System.Xml.Serialization;

namespace ClasesInstanciables
{
    [XmlInclude(typeof(Persona))]
    [XmlInclude(typeof(Universitario))]
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Profesor))]
    [XmlInclude(typeof(Jornada))]
    public class Universidad
    {
        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD};
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto que inicializa los atributos de tipo coleccion
        /// </summary>
        public Universidad()
        {
            Alumnos = new List<Alumno>();
            Instructores = new List<Profesor>();
            Jornadas = new List<Jornada>();
        }
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
                catch(NullReferenceException e)
                {
                    throw new NullReferenceException("Error al tratar de setear un valor de tipo nulo", e);
                }
            }
        }
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                try
                {
                    this.profesores = value;
                }
                catch (NullReferenceException e)
                {
                    throw new NullReferenceException("Error al tratar de setear un valor de tipo nulo", e);
                }
            }
        }
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                try
                {
                    this.jornada = value;
                }
                catch (NullReferenceException e)
                {
                    throw new NullReferenceException("Error al tratar de setear un valor de tipo nulo", e);
                }
            }
        }
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                try
                {
                    this.jornada[i] = value;
                }
                catch (NullReferenceException e)
                {
                    throw new NullReferenceException("Error al tratar de setear un valor de tipo nulo", e);
                }
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra todos los datos de la jornada de una universidad recibica por parametros con sus alumnos y profesores
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>Los datos de la universidad o una excepcion en caso de error</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                if (uni.Jornadas.Count > 0)
                {
                    foreach (Jornada auxJornada in uni.Jornadas)
                    {
                        sb.AppendLine(auxJornada.ToString());
                    }
                }
                else
                {
                    sb.AppendLine("No se encontraron jornadas para esta universidad");
                }
                return sb.ToString();
            }
            catch(NullReferenceException e)
            {
                throw new NullReferenceException("Error, la instancia de universidad pasada como parametros es de tipo nula", e);
            }
        }
        /// <summary>
        /// Guarda los datos de una universidad pasada por parametros
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>True si se pudo guardar con exito, false caso contrario</returns>
        public static bool Guardar(Universidad uni)
        {
            bool archivoGuardado;
            try
            {
                Xml<Universidad> archivoXml = new Xml<Universidad>();
                archivoGuardado = archivoXml.Guardar("Universidad.xml", uni);
                return archivoGuardado;
            }
            catch (InvalidOperationException e)
            {
                throw new ArchivosException("Error, no se pudo guardar el archivo", e);
            }
            catch (Exception e)
            {
                throw new ArchivosException("Error, no se pudo guardar el archivo", e);
            }
        }
        /// <summary>
        /// Se encarga de leer los datos del archivo "Universidad.xml"
        /// </summary>
        /// <returns>Una instancia de tipo Universidad con todos los datos del archivo, o una excepcion en caso de error</returns>
        public static Universidad Leer()
        {
            bool archivoLeido;
            Universidad auxUniversidad;
            try
            {
                Xml<Universidad> archivoXml = new Xml<Universidad>();
                archivoLeido = archivoXml.Leer("Universidad.xml", out auxUniversidad);
                return auxUniversidad;
            }
            catch (InvalidOperationException e)
            {
                throw new ArchivosException("No se pudo leer el archivo", e);
            }
            catch (Exception e)
            {
                throw new ArchivosException("No se pudo leer el archivo", e);
            }
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Muestra todos los datos de una universidad llamando a metodo MostrarDatos
        /// </summary>
        /// <returns>Los datos de la universidad</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        /// <summary>
        /// Compara que un alumno perteneza a una universidad, recorriendo la coleccion de alumnos registrados
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>True si el alumno existe, false caso contrario</returns>
        public static bool operator ==(Universidad g, Alumno a) 
        {
            bool ret = false;
            try
            {
                foreach (Alumno auxAlumno in g.Alumnos)
                {
                    if (auxAlumno == a)
                    {
                        ret = true;
                    }
                }
                return ret;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Referencia a la instancias de universidad o alumno es null", e);
            }
        }
        /// <summary>
        /// Comprueba que un alumno NO pertenezca a una universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>True si el alumno no pertenece, false caso contrario</returns>
        public static bool operator !=(Universidad g, Alumno a) { return !(g == a); }
        
        /// <summary>
        /// Agrega un alumno a una universidad, no sin antes comprobar que no halla sido cargado previamente
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns>True si se pudo agregar, false caso contrario</returns>
        public static Universidad operator +(Universidad u, Alumno a) 
        {
            try
            {
                if(u == a)
                {
                    return u;
                }
                u.Alumnos.Add(a);
                return u;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Referencia a la instancias de universidad o alumno es null", e);
            }
        }
        /// <summary>
        /// Comprueba que un profesor no existe en la coleccion de profesores
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns>True si existe, false caso contrario</returns>
        public static bool operator ==(Universidad g, Profesor i) 
        {
            bool ret = false;
            try
            {
                foreach (Profesor auxProfesor in g.Instructores)
                {
                    if (auxProfesor == i)
                    {
                        ret = true;
                    }
                }
                return ret;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Referencia a la instancias de universidad o profesor es null", e);
            }
        }
        /// <summary>
        /// Comprueba que un profesor NO exista en la coleccion de profesores
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns>True si no existe, false caso contrario</returns>
        public static bool operator !=(Universidad g, Profesor i) { return !(g == i); }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            try
            {
                if(u == i)
                {
                     return u;
                }
                u.Instructores.Add(i);
                return u;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Referencia a la instancias de universidad o profesor es null", e);
            }
        }
        /// <summary>
        /// Comprueba que una clase sea dictada por un profesor
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns>El profesor que dicta la clase caso de exito, sino una excepcion</returns>
        public static Profesor operator ==(Universidad u, EClases clase) 
        {
            try
            {
                foreach (Profesor auxProfesor in u.Instructores)
                {
                    if (auxProfesor == clase)
                    {
                        return auxProfesor;
                    }
                }
                throw new SinProfesorException();
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Referencia a la instancias de universidad o clase es null", e);
            }
        }
        /// <summary>
        /// Busca el primer profesor que NO de la clase pasada por parametros
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns>El profesor encontrado caso de exito, sino una excepcion</returns>
        public static Profesor operator !=(Universidad u, EClases clase) 
        {
            try
            {
                foreach (Profesor auxProfesor in u.Instructores)
                {
                    if (auxProfesor != clase)
                    {
                        return auxProfesor;
                    }
                }
                throw new SinProfesorException("Ya existe un profesor designado para la clase");
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Referencia a la instancias de universidad o clase es null", e);
            }
        }
        /// <summary>
        /// Agrega una nueva jornada a la instancia de universidad, verificando primero que halla un profesor
        /// que dicte la Clase pasada por parametros
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna la universidad con la jornada adherida caso de exito, o una excepcion</returns>
        public static Universidad operator +(Universidad g, EClases clase) 
        {
            try
            {
                Profesor auxProfe = (g == clase);
                Jornada auxJornada = new Jornada(clase, auxProfe);
                foreach (Alumno auxAlumnos in g.Alumnos)
                {
                    if (auxAlumnos == clase)
                    {
                        auxJornada.Alumnos.Add(auxAlumnos);
                    }
                }
                g.Jornadas.Add(auxJornada);
                return g;
            }
            catch (SinProfesorException e)
            {
                throw new SinProfesorException("No hay profesores para la Clase", e);
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("Referencia a la instancias de universidad o clase es null", e);
            }
        }
        #endregion
    }
}
