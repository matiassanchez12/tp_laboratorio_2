using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        #region Atributos
        private int idDeEmpleado;
        private TipoCliente tipo;
        private Artefactos artefactos;
        #endregion

        #region Enumerados
        public enum TipoCliente { Conocido, Desconocido};
        #endregion

        #region Propiedades
        public Artefactos Artefactos
        {
            get 
            {
                return this.artefactos;
            }
            set 
            {
                this.artefactos = value;
            }
        }
        public int IdDeEmpleado
        {
            get
            {
                return this.idDeEmpleado;
            }
            set
            {
                this.idDeEmpleado = value;
            }
        }
        public TipoCliente Tipo
        {
            get 
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        #region Constructores
        public Cliente()
        {

        }
        public Cliente(Artefactos artefactos, string nombre, string apellido, string domicilio, int tel, int cel, int idEmpleado, TipoCliente tipo)
         : base(nombre, apellido, domicilio, tel, cel)
        {
            this.Artefactos = artefactos;
            this.IdDeEmpleado = idEmpleado;
            this.Tipo = tipo;
        }
        public Cliente(Artefactos artefactos, string nombre, string apellido, string domicilio, string tel, string cel, int idEmpleado, TipoCliente tipo)
            : base(nombre, apellido, domicilio, tel, cel)
        {
            this.Artefactos = artefactos;
            this.Tipo = tipo;
            this.IdDeEmpleado = idEmpleado;
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  Datos Cliente:");
            sb.AppendLine($"Id del Empleado que lo atiende: {this.IdDeEmpleado}");
            sb.AppendLine($"Tipo: {this.Tipo}");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(" Artefactos del cliente:");
            if(this.Artefactos.Articulos.Count == 0)
            {
                sb.AppendLine("Este cliente no cuenta con artefactos");
            }
            foreach (Articulo auxArticulo in this.Artefactos.Articulos)
            {
                sb.AppendLine(auxArticulo.ToString());
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
