using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo
    {
        #region Atributos
        private string nombre;
        private Tipo tipoEquipo;
        private string accesorios;
        private int numeroRetiro;
        private string comentario;
        public enum Tipo { TV, Radio, AcondicionadorDeAire, Heladera, Otro};
        #endregion

        #region Propiedades
        public int NumeroRetiro
        {
            get
            {
                return this.numeroRetiro;
            }
            set
            {
                this.numeroRetiro = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Comentario
        {
            get
            {
                return this.comentario;
            }
            set
            {
                this.comentario = value;
            }
        }
        public string Accesorios
        {
            get
            {
                return this.accesorios;
            }
            set
            {
                this.accesorios = value;
            }
        }
        public Tipo TipoEquipo
        {
            get
            {
                return this.tipoEquipo;
            }
            set
            {
                this.tipoEquipo = value;
            }
        }
        #endregion

        #region Constructor
        public Articulo()
        {

        }
        public Articulo(string nombre, int nroRetiro, Tipo tipo, string accesorios, string comentarios)
        {
            this.numeroRetiro = nroRetiro;
            this.nombre = nombre;
            this.tipoEquipo = tipo;
            this.accesorios = accesorios;
            this.Comentario = comentarios;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Articulo: ");
            sb.AppendLine($"  Nombre: {this.Nombre}");
            sb.AppendLine($"  Numero de Retiro: {this.NumeroRetiro}");
            sb.AppendLine($"  Tipo de Equipo: {this.TipoEquipo}");
            sb.AppendLine($"  Accesorios: {this.Accesorios}");
            sb.AppendLine($"  Comentarios: {this.Comentario}");
            return sb.ToString();
        }
        public static bool operator ==(Articulo a1, Articulo a2)
        {
            bool ret = false;
            if(a1.Nombre == a2.Nombre && a1.NumeroRetiro == a2.NumeroRetiro)
            {
                ret = true;
            }
            return ret;
        }
        public static bool operator !=(Articulo a1, Articulo a2)
        {
            return !(a1 == a2);
        }
        #endregion

    }
}
