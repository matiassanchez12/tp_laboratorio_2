using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor parametrizado, inicializa marca, chasis y color utilizando el constructor de la base
        /// </summary>
        /// <param name="marca">El tipo de marca</param>
        /// <param name="chasis">El tipo de chasis</param>
        /// <param name="color">El tipo de color</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) :base(chasis, marca, color){ }

        /// <summary>
        /// Las motos son chicas
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Muestra datos generales del vehiculo y el tamaño
        /// </summary>
        /// <returns>Los datos en forma de string del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
