using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    { 
        private int id;
        public int Id
        {
            get 
            {
                return this.id;
            }
            set
            {
                this.id = value; 
            }
        }

        public Empleado()
        {

        }
        public Empleado(string nombre, string apellido, string domicilio, int tel, int cel, int id)
            : base(nombre, apellido, domicilio, tel, cel)
        {
            this.Id = id;
        }
        public Empleado(string nombre, string apellido, string domicilio, string tel, string cel, int id) 
            : base(nombre, apellido, domicilio, tel, cel) 
        {
            this.Id = id;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  Datos Empleado: ");
            sb.AppendLine($"Id: {this.Id}");
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
