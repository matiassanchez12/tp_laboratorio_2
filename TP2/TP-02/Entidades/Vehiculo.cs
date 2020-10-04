using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Enumerados

        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        #endregion

        #region Atributos

        EMarca marca;
        protected string chasis;
        protected ConsoleColor color;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor parametrizado de vehiculo
        /// </summary>
        /// <param name="chasis">Nombre del chasis</param>
        /// <param name="marca">Tipo de marca</param>
        /// <param name="color">Tipo de color</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio { get;}


        #endregion

        #region Metodos

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Datos del vehiculo</returns>
        public virtual string Mostrar()
        {
            StringBuilder infoVehiculo = new StringBuilder();
            infoVehiculo.AppendLine($"CHASIS: {chasis}");
            infoVehiculo.AppendLine($"MARCA: {marca}");
            infoVehiculo.AppendLine($"COLOR: {color}");
            infoVehiculo.AppendLine("---------------------");

            return infoVehiculo.ToString();
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del metodo string, devuelve datos generales de un vehiculo
        /// </summary>
        /// <param name="p">Recibe un vehiculo</param>
        /// <returns>Los datos del vehiculo</returns>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CHASIS: {p.chasis}\r\n");
            sb.AppendLine($"MARCA : {p.marca}\r\n");
            sb.AppendLine($"COLOR : {p.color}\r\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Un vehiculo</param>
        /// <param name="v2">Vehiculo a comparar</param>
        /// <returns>True en caso de que sean igual, sino False</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Un vehiculo</param>
        /// <param name="v2">Vehiculo a comparar</param>
        /// <returns>True en caso de que sean distintos, sino False</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }

        #endregion

    }
}
