using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    public class Universidad
    {
        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD};
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
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
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
                this.jornada = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                return jornada[i];
            }
            set
            {
                jornada[i] = value;
            }
        }
        #endregion

        #region Constructores
        public Universidad()
        {
            Alumnos = new List<Alumno>();
            Instructores = new List<Profesor>();
            Jornadas = new List<Jornada>();
        }
        #endregion

        #region Metodos
        
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
        public static bool Guardar(Universidad uni)
        {
            bool ret = false;
            try
            {

            }
            catch (ArgumentNullException e)
            {
                throw new ArchivosException(e);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return ret;
        }
        public Universidad Leer()
        {
            return this;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        public static bool operator ==(Universidad g, Alumno a) 
        {
            bool ret = false;
            foreach (Alumno auxAlumno in g.Alumnos)
            {
                if(auxAlumno == a) 
                {
                    ret = true;
                }
            }
            return ret;
        }
        public static bool operator !=(Universidad g, Alumno a) { return !(g == a); }
        public static Universidad operator +(Universidad u, Alumno a) 
        {
            if(u == a)
            {
             throw new AlumnoRepetidoException();
            }
            u.Alumnos.Add(a);
            
            return u;
        }
        public static bool operator ==(Universidad g, Profesor i) 
        {
            bool ret = false;
            foreach (Profesor auxProfesor in g.Instructores)
            {
                if(auxProfesor == i)
                {
                    ret = true;
                }
            }
            return ret;
        }
        public static bool operator !=(Universidad g, Profesor i) { return !(g == i); }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if(u == i)
            {
                return u;
            }
            u.Instructores.Add(i);

            return u;
        }
        public static Profesor operator ==(Universidad u, EClases clase) 
        {
            foreach (Profesor auxProfesor in u.Instructores)
                {
                    if(auxProfesor == clase)
                    {
                        return auxProfesor;
                    }
                }
           throw new SinProfesorException();
        }
        public static Profesor operator !=(Universidad u, EClases clase) 
        {
            foreach (Profesor auxProfesor in u.Instructores)
            {
                if (auxProfesor != clase)
                {
                    return auxProfesor;
                }
            }
            throw new SinProfesorException();
        }
        public static Universidad operator +(Universidad g, EClases clase) 
        {
            Profesor auxProfe = (g == clase);
            Jornada auxJornada = new Jornada(clase, auxProfe);
            foreach (Alumno auxAlumnos in g.Alumnos)
            {
                if(auxAlumnos == clase)
                {
                    auxJornada.Alumnos.Add(auxAlumnos);
                }
            }
            g.Jornadas.Add(auxJornada);
            return g;
        }

        #endregion
    }
}
