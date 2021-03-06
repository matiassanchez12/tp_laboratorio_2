﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        #region Atributos

        private List<Vehiculo> vehiculos;
        private int espacioDisponible;

        #endregion

        #region Enumerados

        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor por defecto, inicializa la lista de vehiculos.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor parametrizado, reutilizo el primer constructor y ademas inicializo el espacio disponible
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine();
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v.GetType().Name.ToLower() == tipo.ToString().ToLower())
                {
                    sb.AppendLine(v.Mostrar());
                }
                if(tipo == ETipo.Todos)
                {
                   sb.AppendLine(v.Mostrar());
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Sobrecargas de Operadores"

        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }

        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns>Caso de exito, devuelve taller con el vehiculo, sino el mismo taller que se paso como parametro</returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    return taller;
                }
            }

            if(taller.vehiculos.Count < taller.espacioDisponible)
            {
              taller.vehiculos.Add(vehiculo);
            }

            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>Caso de exito, devuelve taller sin el vehiculo, sino el mismo taller que se paso como parametro</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(v);
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
