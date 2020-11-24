using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos

        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private int celular;

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
                this.nombre = this.ValidarNombreApellido(value); 
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
                this.apellido = this.ValidarNombreApellido(value);
            }
        }
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
        public int Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }
        public string StringToTelefono
        {
            set
            {
                this.Telefono = this.ValidarTelefono(value);
            }
        }
        public int Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                this.celular = value;
            }
        }
        public string StringToCelular
        {
            set
            {
                this.Celular = this.ValidarCelular(value);
            }
        }
        #endregion

        #region Constructores
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, string domicilio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = domicilio;
        }
        public Persona(string nombre, string apellido, string domicilio, int telefono, int celular):this(nombre, apellido, domicilio)
        {
            this.Telefono = telefono;
            this.Celular = celular;
        }
        public Persona(string nombre, string apellido, string domicilio, string telefono, string celular) : this(nombre, apellido, domicilio)
        {
            this.StringToTelefono = telefono;
            this.StringToCelular = celular;
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre} - Apellido: {this.Apellido} ");
            sb.AppendLine($"Domicilio: {this.Direccion}\nTelefono: {this.Telefono} \nCelular: {this.Celular}");
            return sb.ToString();
        }
        private string ValidarNombreApellido(string dato)
        {
            string validString = "";

            if (Regex.IsMatch(dato, @"[a-zA-ZñÑ\s]"))
            {
                validString = dato;
            }
            return validString;
        }
        private int ValidarTelefono(string dato)
        {
            int auxTel;
            
            try
            {
                dato = dato.Replace("-", "");

                if (dato.Length < 1 || dato.Length > 8)
                {
                    throw new Exception();
                }

                auxTel = Int32.Parse(dato);
            }
            catch (Exception e)
            {
                throw new Exception($"Error, el nro de telefono ingresado no es correcto {dato}", e);
            }

            return auxTel;
        }
        private int ValidarCelular(string dato)
        {
            int auxCel;

            try
            {
                dato = dato.Replace("-", "");

                if (dato.Length < 1 || dato.Length > 15)
                {
                    throw new Exception();
                }

                auxCel = Int32.Parse(dato);
            }
            catch (Exception e)
            {
                throw new Exception($"Error, el nro de celular ingresado no es correcto {dato}", e);
            }

            return auxCel;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Persona psona1, Persona psona2)
        {
            bool ret = false;
            if (!(psona1.Equals(null)) && !(psona2.Equals(null)))
            {
                if(psona1.Celular == psona2.Celular && psona1.Nombre == psona2.Nombre)
                {
                    ret = true;
                }
            }
            return ret;
        }
        public static bool operator !=(Persona psona1, Persona psona2)
        {
            return !(psona1 == psona2);
        }
        #endregion
    }
}
