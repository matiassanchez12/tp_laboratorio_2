using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, no inicializa ningun atributo
        /// </summary>
        public Persona()
        {

        }
        /// <summary>
        /// Constructor con parametros, inicializa atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Constructor con parametros, inicializa atributos y el dni de tipo entero
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Constructor con parametros, inicializa atributos y el dni de tipo string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
            }
        }
        public string StringToDNI
        {
            set
            {
                this.DNI = ValidarDni(this.nacionalidad, value);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que sirve para validar que un dni sea de tipo argentino o extranjero
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>El dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato > 0 && dato < 99999999)
            {
                switch (nacionalidad)
                {
                    case ENacionalidad.Argentino:
                        if (dato < 1 || dato > 89999999)
                            throw new NacionalidadInvalidaException();
                        break;
                    case ENacionalidad.Extranjero:
                        if (dato < 89999999 || dato > 99999999)
                            throw new NacionalidadInvalidaException();
                        break;
                }
            }
            else
            {
                throw new DniInvalidoException("El DNI ingresado es incorrecto, no debe ser menor a 0 ni mayor a 99999999");
            }
            return dato;
           
        }
        /// <summary>
        ///  Metodo que sirve para validar que un string tenga las caracteristicas de un dni
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>El dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int auxDni;
            dato = dato.Replace(".", "");

            if (dato.Length < 1 || dato.Length > 8)
                throw new DniInvalidoException(dato.ToString());

            try
            {
                auxDni = Int32.Parse(dato);
            }
            catch (Exception e)
            {
                throw new DniInvalidoException(dato.ToString(), e);
            }

            return ValidarDni(nacionalidad, auxDni);
        }
        /// <summary>
        /// Valida que el dato pasado como parametro sea una cadena, sin otro tipo de caracteres que letras
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>La cadena que se validó</returns>
        private string ValidarNombreApellido(string dato)
        {
            string validString = "";
            
            if (Regex.IsMatch(dato, @"[a-zA-ZñÑ\s]"))
            {
                validString = dato;
            }
            return validString;
            
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Muestra todos los datos de una persona
        /// </summary>
        /// <returns>Los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE COMPLETO: {this.Nombre}, {this.Apellido}");
            sb.Append($"NACIONALIDAD: {this.Nacionalidad}");
            return sb.ToString();
        }
        #endregion
    }
}
