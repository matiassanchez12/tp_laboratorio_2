using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    /// <summary>
    /// Utilizo metodos de extension
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Metodo de extension, su funcion es modificar un articulo de la base
        /// de datos. Para ello los datos del articulo que utiliza esta extension
        /// y una palabra con el nombre del articulo en la DB a modificar.
        /// Tambien se encarga de verificar si el articulo es radio o tv, para reemplazar
        /// los datos correspondientes
        /// </summary>
        /// <param name="articulo">el articulo con datos a modificar</param>
        /// <param name="auxNombre">el nombre del articulo en la BD</param>
        /// <returns>True si se pudieron reemplazar los datos, false caso contrario</returns>
        public static bool ModificarArticuloEnBD(this Articulo articulo, string auxNombre)
        {
            bool ret = false;
            
            string auxVacio = "-1";
            
            SqlConnection conexionSql = new SqlConnection(@"Server = localhost\SQLEXPRESS; Database = Negocio; Trusted_Connection=True;");
            try
            {

                SqlCommand commandSql = new SqlCommand();

                commandSql.Connection = conexionSql;
                commandSql.CommandType = CommandType.Text;

                commandSql.CommandText = "UPDATE Articulos SET nombre = @nombre, marca = @marca, idCliente = @idCliente," +
                    "costo = @costo, estado = @estado, peso= @peso, antiguedad= @antiguedad where nombre = @auxNombre";

                //parametro que sirve para encontrar el articulo correcto de la BD
                commandSql.Parameters.Add(new SqlParameter("@auxNombre", auxNombre));

                if (articulo is Radio)
                {
                    Radio auxRadio = (Radio)articulo;
                    commandSql.Parameters.Add(new SqlParameter("@nombre", auxRadio.NombreArticulo));
                    commandSql.Parameters.Add(new SqlParameter("@marca", auxRadio.Marca));
                    commandSql.Parameters.Add(new SqlParameter("@costo", auxRadio.Costo));
                    commandSql.Parameters.Add(new SqlParameter("@estado", auxRadio.EstadoArticulo.ToString()));
                    commandSql.Parameters.Add(new SqlParameter("@idCliente", auxRadio.IdClienteComprador));
                    commandSql.Parameters.Add(new SqlParameter("@peso", auxVacio));
                    commandSql.Parameters.Add(new SqlParameter("@antiguedad", auxRadio.AniosDeAntiguedad));
                }
                else
                {
                    TV auxTV = (TV)articulo;
                    commandSql.Parameters.Add(new SqlParameter("@nombre", auxTV.NombreArticulo));
                    commandSql.Parameters.Add(new SqlParameter("@marca", auxTV.Marca));
                    commandSql.Parameters.Add(new SqlParameter("@costo", auxTV.Costo));
                    commandSql.Parameters.Add(new SqlParameter("@estado", auxTV.EstadoArticulo.ToString()));
                    commandSql.Parameters.Add(new SqlParameter("@idCliente", auxTV.IdClienteComprador));
                    commandSql.Parameters.Add(new SqlParameter("@peso", auxTV.Peso));
                    commandSql.Parameters.Add(new SqlParameter("@antiguedad", auxVacio));
                }
            
                if (conexionSql.State != ConnectionState.Open)
                {
                    conexionSql.Open();
                }

                // si no se modifica ningun articulo, lanzo una excepcion
                if (commandSql.ExecuteNonQuery() == 0)
                {
                    throw new ConexionDBException();
                }

                ret = true;
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Ocurrio un error al tratar de modificar el articulo", ex);
            }
            finally
            {
                if (conexionSql.State == ConnectionState.Open)
                {
                    conexionSql.Close();
                }
            }

            return ret;
        }
    }
}
