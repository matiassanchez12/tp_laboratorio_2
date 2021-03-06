﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor:Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores
        /// <summary>
        /// Constructor por defecto estatico, inicializa el Atributo random 
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }
        /// <summary>
        /// Constructor por defecto, inicializa clasesDelDia, seteando dos clasesDelDia
        /// seleccionadas de forma random, con el metodo _randomclases.
        /// </summary>
        public Profesor()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }
        /// <summary>
        /// Constructor parametrizado, reutilizando el constructor base para inicilizar 
        /// los atributos heredados. Tambien inicializa clasesDelDia, seteando dos clasesDelDia 
        /// seleccionadas de forma random, con el metodo _randomclases.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra todos los datos de un profesor, incluidos los que son heredados
        /// </summary>
        /// <returns>Todos los datos en forma de string</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.AppendLine(base.MostrarDatos());
                sb.AppendLine(this.ParticiparEnClase());
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("Ocurrio un error al cargar los datos", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error al cargar los datos", e);
            }
            return sb.ToString();
        }
        /// <summary>
        /// Devuelve en forma de string las clases del dia del profesor
        /// </summary>
        /// <returns>String con todas las clases del profesor</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.AppendLine("CLASES DEL DIA: ");
                foreach (Universidad.EClases clase in this.clasesDelDia)
                {
                    sb.AppendLine(Enum.GetName(typeof(Universidad.EClases), clase));
                }
                return sb.ToString();
            }
            catch (Exception e)
            {
                throw new Exception("Error al ejecutar metodo ParticiparEnClase", e);
            }
        }
        /// <summary>
        /// Este metodo sirve para agregar a la Queue 2 clases 
        /// obtenidas utilizando el metodo random.next, con el cual 
        /// se crean numeros de forma aleatoria y luego con ese numero
        /// se selecciona un dato del enumerado. 
        /// </summary>
        private void _randomClases()
        {
            int cantEnum = Enum.GetNames(typeof(Universidad.EClases)).Length;
            int numberRandom = Profesor.random.Next(0, cantEnum);
            this.clasesDelDia.Enqueue((Universidad.EClases)numberRandom);
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Se encarga de hacer publico los datos de esta clase
        /// </summary>
        /// <returns>Los datos de un profesor en forma de string</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Verifica si un profesor y una clase son iguales, solo si, da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns>False cuando el profesor no dicte esa clase, True caso positivo</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool ret = false;
            try
            {
                if (i.clasesDelDia.Count > 0)
                {
                    foreach (Universidad.EClases auxClase in i.clasesDelDia)
                    {
                        if (auxClase == clase)
                        {
                            ret = true;
                            break;
                        }
                    }
                }
            }
           catch (NullReferenceException e)
            {
                throw new NullReferenceException("Instancia de Profesor o de EClases pasadas como parametro es null", e);
            }
            return ret;
        }
        /// <summary>
        /// Verifica si un profesor y una clase son distintos, solo si, da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns>False cuando el profesor dicte esa clase, True el profesor no dicta la clase</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase) { return !(i == clase); }

        #endregion
    }
}
