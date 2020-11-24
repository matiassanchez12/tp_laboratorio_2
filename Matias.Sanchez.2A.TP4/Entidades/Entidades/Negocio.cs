using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Negocio
    {
        #region Atributos
        private List<Empleado> empleados;
        private List<Cliente> clientes;
        private string nombreNegocio;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get 
            {
                return this.nombreNegocio;
            }
            set 
            {
                this.nombreNegocio = this.ValidarNombre(value); 
            }
        }
        public List<Empleado> Empleados 
        {
            get 
            {
                return this.empleados;
            }
            set 
            {
                this.empleados = value;
            } 
        }
        public List<Cliente> Clientes
        {
            get
            {
                return this.clientes;
            }
            set
            {
                this.clientes = value;
            }
        }
        #endregion

        #region Constructores
        public Negocio()
        {
            this.Empleados = new List<Empleado>();
            this.Clientes = new List<Cliente>();
        }
        public Negocio(string nombre):this()
        {
            this.Nombre = nombre;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del negocio: {this.Nombre}  ");
            sb.AppendLine();
            if(this.Empleados.Count != 0)
            {
                sb.AppendLine(" LISTA DE EMPLEADOS ");
                foreach (Empleado auxEmpleado in this.Empleados)
                {
                    sb.Append(auxEmpleado.ToString());
                    sb.AppendLine(" CLIENTELA DEL EMPLEADO ");
                    if (this.Clientes.Count == 0)
                    {
                        sb.AppendLine(" Atencion! El empleado no gestiona clientes todavia");
                        sb.AppendLine();
                    }
                    foreach (Cliente auxClientes in this.Clientes)
                    {
                        if (auxEmpleado.Id == auxClientes.IdDeEmpleado)
                        {
                            sb.AppendLine(auxClientes.ToString());
                        }
                    }
                    sb.AppendLine("------------------------------------------------------------------");
                }
            }
            else
            {
                sb.AppendLine(" Atencion! No se gestionan empleados, ni clientes todavia");
            }
            return sb.ToString();
        }
        private string ValidarNombre(string dato)
        {
            string validString;

            if (Regex.IsMatch(dato, @"[a-zA-ZñÑ\s]"))
            {
                validString = dato;
            }
            else
            {
                throw new Exception("Error, no es valido el nombre ingresado");
            }
            return validString;
        }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator ==(Negocio n, Cliente c1)
        {
            bool ret = false;
            if(!(n.Equals(null)) && !(c1.Equals(null)))
            {
                foreach (Cliente auxCliente in n.Clientes)
                {
                    if(auxCliente == c1)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }
        public static bool operator !=(Negocio n, Cliente c1)
        {
            return !(n == c1);
        }
        public static Negocio operator +(Negocio n, Cliente c1)
        {
            if(n != c1)
            {
                n.Clientes.Add(c1);
            }
            return n;
        }
        public static Negocio operator -(Negocio n, Cliente c1)
        {
            if(n == c1)
            {
                n.Clientes.Remove(c1);
            }
            return n;
        }
        public static bool operator ==(Negocio n, Empleado e1)
        {
            bool ret = false;
            if (!(n.Equals(null)) && !(e1.Equals(null)))
            {
                foreach (Empleado auxEmpleado in n.Empleados)
                {
                    if(auxEmpleado == e1 || auxEmpleado.Id == e1.Id)
                    {
                        ret = true;
                    }
                }
            }
            return ret;
        }
        public static bool operator !=(Negocio n, Empleado e1)
        {
            return !(n == e1);
        }
        public static Negocio operator +(Negocio n, Empleado e1)
        {
            if(n != e1)
            {
                n.Empleados.Add(e1);
            }
            else
            {
                throw new Exception("Error, los id de los empleados son iguales");
            }
            return n;
        }
        public static Negocio operator -(Negocio n, Empleado e1)
        {
            if (n == e1)
            {
                n.Empleados.Remove(e1);
            }
            return n;
        }
        #endregion
    }
}
