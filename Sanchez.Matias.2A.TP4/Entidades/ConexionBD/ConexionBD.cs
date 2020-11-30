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
    /// Utilizo conocimientos sobre Base de datos y sql
    /// </summary>
    public static class ConexionBD
    {
        static SqlConnection conexionSql;
        
        #region Constructores
        /// <summary>
        /// Constructor por defecto, crea la conexion a la base de datos
        /// </summary>
        static ConexionBD()
        {
            conexionSql = new SqlConnection(@"Server = localhost\SQLEXPRESS; Database = Negocio; Trusted_Connection=True;");
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Trae los datos de los clientes de la base de datos y los devuelve
        /// en forma de lista
        /// </summary>
        /// <returns>Listado de clientes o si ocurre un error, null</returns>
        public static List<Cliente> GetClientes()
        {
            List<Cliente> auxClientes = new List<Cliente>();
            
            try
            {
                SqlCommand comandoSql = new SqlCommand();

                comandoSql.Connection = conexionSql;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "SELECT * FROM Clientes";

                if (conexionSql.State != ConnectionState.Open)
                { 
                    conexionSql.Open();
                }

                SqlDataReader datos = comandoSql.ExecuteReader();

                while (datos.Read())
                {
                    auxClientes.Add(new Cliente(int.Parse(datos["id"].ToString()), datos["nombre"].ToString(), datos["dni"].ToString(),
                                                BuscarMedioDePago(datos["formaDePago"].ToString()), Char.Parse(datos["sexo"].ToString().ToLower())));
                }

                datos.Close();
            }
            catch (Exception ex)
            {
                auxClientes = null;
            }

            finally
            {
                if (conexionSql.State == ConnectionState.Open)
                {
                    conexionSql.Close();
                }
            }
            return auxClientes;
        }
        /// <summary>
        /// Recibe una palabra que va a servir para identificar que 
        /// medio de pago es, en el enumero EMedioDePago
        /// </summary>
        /// <param name="aux">Palabra a filtrar</param>
        /// <returns>Retorna el medio de pago de tipo enumerado</returns>
        public static EMedioDePago BuscarMedioDePago(string aux)
        {
            switch (aux)
            {
                case "Efectivo":
                    return EMedioDePago.Efectivo;
                case "Credito":
                    return EMedioDePago.Credito;
                case "Debito":
                    return EMedioDePago.Debito;
                case "MercadoPago":
                    return EMedioDePago.MercadoPago;
                case "Otro":
                    return EMedioDePago.Otro;
                default:
                    return EMedioDePago.SinDatos;
            }
        }
        /// <summary>
        /// Inserta un cliente a la base de datos
        /// Utilizo Excepciones
        /// </summary>
        /// <param name="cliente">Recibe un cliente a ser guardado en la BD</param>
        public static void InsertCliente(Cliente cliente)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();

                comandoSql.Connection = conexionSql;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "INSERT INTO [dbo].[Clientes] ([id], [nombre], [dni], [formaDePago], [sexo]) " +
                    "VALUES(@id,@nombre,@dni,@formaDePago,@sexo)";
                
                comandoSql.Parameters.Add(new SqlParameter("@id", cliente.Id));
                comandoSql.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
                comandoSql.Parameters.Add(new SqlParameter("@dni", cliente.Dni));
                comandoSql.Parameters.Add(new SqlParameter("@formaDePago", cliente.FormaPago.ToString()));
                comandoSql.Parameters.Add(new SqlParameter("@sexo", cliente.Sexo.ToString().ToLower()));


                if (conexionSql.State != ConnectionState.Open)
                { 
                    conexionSql.Open();
                }

                comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Ocurrio un error al insertar el Cliente", ex);
            }
            finally
            {
                if (conexionSql.State == ConnectionState.Open)
                {
                    conexionSql.Close();
                }
            }
        }
        /// <summary>
        /// Elimina un cliente de la base de datos
        /// </summary>
        /// <param name="cli">El cliente a ser eliminado</param>
        /// <returns>True en caso de eliminacion correcta, caso contrario false</returns>
        public static bool EliminarCliente(Cliente cli)
        {
            bool ret = false;
            try
            {
                SqlCommand comandoSql = new SqlCommand();

                comandoSql.Connection = conexionSql;

                comandoSql.CommandType = CommandType.Text;

                comandoSql.CommandText = "DELETE Clientes where id = @auxId";

                comandoSql.Parameters.Add(new SqlParameter("@auxId", cli.Id));

                if (conexionSql.State != ConnectionState.Open)
                {
                    conexionSql.Open();
                }

                if(comandoSql.ExecuteNonQuery() != 0)
                {
                    ret = true;
                }
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Ocurrio un error al eliminar el Cliente", ex);
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
        /// <summary>
        /// Trae los articulos de la base de datos y los almacena en una lista,
        /// verificando si los datos traidos son de tipo radio o TV, y utilizando
        /// el constructor correcto en cada caso
        /// </summary>
        /// <returns>Si todo salio bien la lista con los articulos, caso contrario null</returns>
        public static List<Articulo> GetArticulos()
        {
            List<Articulo> auxArticulos = new List<Articulo>();
            try
            {

                SqlCommand comandoSql = new SqlCommand();

                comandoSql.Connection = conexionSql;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "SELECT * FROM Articulos";

                if (conexionSql.State != ConnectionState.Open)
                {
                    conexionSql.Open();
                }

                SqlDataReader datos = comandoSql.ExecuteReader();
              
                while (datos.Read())
                {
                    if (datos["Peso"].ToString() != "")
                    {
                        auxArticulos.Add(new TV(int.Parse(datos["idCliente"].ToString()), 
                                                          datos["Nombre"].ToString(),
                                                          datos["Marca"].ToString(),
                                                          BuscarEstadoArticulo(datos["Estado"].ToString()),
                                                          double.Parse(datos["Peso"].ToString()),
                                                          double.Parse(datos["Costo"].ToString())
                                                          ));
                    }
                    else
                    {
                        auxArticulos.Add(new Radio(int.Parse(datos["idCliente"].ToString()),
                                                          datos["Nombre"].ToString(),
                                                          datos["Marca"].ToString(),
                                                          BuscarEstadoArticulo(datos["Estado"].ToString()),
                                                          double.Parse(datos["costo"].ToString()),
                                                          int.Parse(datos["antiguedad"].ToString())
                                                          ));
                    }
                }

                datos.Close();
            }
            catch (Exception ex)
            {
                auxArticulos = null;
            }
            finally
            {
                if (conexionSql.State != ConnectionState.Open)
                {
                    conexionSql.Close();
                }
            }
            return auxArticulos;
        }
        /// <summary>
        /// Busca en el enumerado EEstado si coincide con la
        /// palabra pasada por parametro
        /// </summary>
        /// <param name="aux">Palabra a verificar</param>
        /// <returns>El enumerado correcto o EEstado.Nuevo</returns>
        public static EEstado BuscarEstadoArticulo(string aux)
        {
            switch (aux)
            {
                case "Usado":
                    return EEstado.Usado;
                case "Nuevo":
                    return EEstado.Nuevo;
                default:
                    return EEstado.Nuevo;
            }
        }
        /// <summary>
        /// Inserta un articulo en la base de datos, verificando si es radio o si es tv
        /// para pasarle a la base de datos, todos valores validos
        /// </summary>
        /// <param name="articulo">Recibe un articulo</param>
        public static void InsertArticulo(Articulo articulo)
        {
            string auxVoid = "";
            try
            {
                SqlCommand comandoSql = new SqlCommand();

                comandoSql.Connection = conexionSql;
                comandoSql.CommandType = CommandType.Text;
            
                if(articulo is Radio)
                {
                    comandoSql.CommandText = "INSERT INTO [dbo].[Articulos] ([nombre],[marca],[costo],[estado],[peso],[antiguedad],[idCliente])" +
                        " VALUES(@nombre,@marca, @costo, @estado, @peso, @antiguedad, @idCliente)";
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", articulo.IdClienteComprador));
                    comandoSql.Parameters.Add(new SqlParameter("@nombre", articulo.NombreArticulo));
                    comandoSql.Parameters.Add(new SqlParameter("@marca", articulo.Marca));
                    comandoSql.Parameters.Add(new SqlParameter("@costo", articulo.Costo));
                    comandoSql.Parameters.Add(new SqlParameter("@estado", articulo.EstadoArticulo.ToString()));
                    comandoSql.Parameters.Add(new SqlParameter("@peso", auxVoid));
                    comandoSql.Parameters.Add(new SqlParameter("@antiguedad", ((Radio)articulo).AniosDeAntiguedad));
                }
                else
                {
                    comandoSql.CommandText = "INSERT INTO [dbo].[Articulos] ([nombre],[marca],[costo],[estado],[peso],[antiguedad],[idCliente])" +
                        " VALUES(@nombre,@marca, @costo, @estado, @peso, @antiguedad, @idCliente)";
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", articulo.IdClienteComprador));
                    comandoSql.Parameters.Add(new SqlParameter("@nombre", articulo.NombreArticulo));
                    comandoSql.Parameters.Add(new SqlParameter("@marca", articulo.Marca));
                    comandoSql.Parameters.Add(new SqlParameter("@costo", articulo.Costo));
                    comandoSql.Parameters.Add(new SqlParameter("@estado", articulo.EstadoArticulo.ToString()));
                    comandoSql.Parameters.Add(new SqlParameter("@peso", ((TV)articulo).Peso));
                    comandoSql.Parameters.Add(new SqlParameter("@antiguedad", auxVoid));
                }

                if (conexionSql.State != ConnectionState.Open)
                {
                    conexionSql.Open();
                }

                comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ConexionDBException("Ocurrio un error al insertar el Articulo", ex);
            }
            finally
            {
                if (conexionSql.State == ConnectionState.Open)
                {
                    conexionSql.Close();
                }
            }
        }
        /// <summary>
        /// Elimina un articulo de la base de datos. Recibe un articulo del cual se usara
        /// el nombre para borrar el articulo que coincida con este nombre
        /// </summary>
        /// <param name="art">Articulo del cual se usara el nombre</param>
        /// <returns>True si pudo eliminar correctamente, caso contrario false</returns>
        public static bool EliminarArticulo(Articulo art)
        {
            bool ret = false;
            try
            {
                SqlCommand comandoSql = new SqlCommand();

                comandoSql.Connection = conexionSql;

                comandoSql.CommandType = CommandType.Text;

                comandoSql.CommandText = "DELETE Articulos where nombre = @auxNombre";

                comandoSql.Parameters.Add(new SqlParameter("@auxNombre", art.NombreArticulo));

                if (conexionSql.State != ConnectionState.Open)
                {
                    conexionSql.Open();
                }

                if(comandoSql.ExecuteNonQuery() != 0)
                {
                    ret = true;
                }

            }
            catch(Exception ex)
            {
                throw new ConexionDBException("Ocurrio un error al eliminar el Articulo", ex);
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
        #endregion
    }
}
