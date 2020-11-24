using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Artefactos
    {
        #region Atributos
        private List<Articulo> articulos;
        #endregion

        #region Propiedades
        public List<Articulo> Articulos
        {
            get
            {
                return this.articulos;
            }
            set
            {
                this.articulos = value;
            }
        }
        #endregion

        #region Constructores
        public Artefactos()
        {
            this.Articulos = new List<Articulo>();
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de Artefactos: {this.Articulos.Count}");
            sb.AppendLine($"  Listado de Articulos ");
            foreach (Articulo auxArticulo in this.Articulos)
            {
                sb.AppendLine(auxArticulo.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator ==(Artefactos a, Articulo art)
        {
            bool ret = false;
                foreach (Articulo auxArticulo in a.Articulos)
                {
                    if(auxArticulo == art)
                    {
                        ret = true;
                    }
                }
            return ret;
        }
        public static bool operator !=(Artefactos a, Articulo art)
        {
            return !(a == art);
        }
        public static Artefactos operator +(Artefactos a, Articulo art)
        {
            if(a != art)
            {
                a.Articulos.Add(art);
            }
            return a;
        }
        public static Artefactos operator -(Artefactos a, Articulo art)
        {
            if(a == art)
            {
                a.Articulos.Remove(art);
            }
            return a;
        }
        #endregion
    }
}
