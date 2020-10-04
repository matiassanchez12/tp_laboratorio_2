using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Tipo de marca</param>
        /// <param name="chasis">Tipo de chasis</param>
        /// <param name="color">Tipo de color</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Constructor parametrizado, inicializa marca, chasis y color utilizando el constructor de la base
        /// ademas inicializa el atributo tipo
        /// </summary>
        /// <param name="marca">Tipo de marca</param>
        /// <param name="chasis">Tipo de chasis</param>
        /// <param name="color">Tipo de color</param>
        /// <param name="unTipo">Tipo de vehiculo sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo unTipo)
            : base(chasis, marca, color)
        {
            tipo = unTipo;
        }
        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Muestra datos generales del vehiculo y el tamaño
        /// </summary>
        /// <returns>Los datos en forma de string del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
