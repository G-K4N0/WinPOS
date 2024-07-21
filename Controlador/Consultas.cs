using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using MySqlConnector;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace Controlador
{
    public class Consultas
    {
        Conexion conexion;

        public Consultas()
        {
            conexion = new Conexion();
        }
        #region Inicio de sesion
        public Dictionary<string, object> checkUser(string usuario, string passwd)
        {
            string consulta = "SELECT personas.id AS id, personas.nombre AS nombre, " +
                "personas.usuario AS usuario, personas.passwd AS password, roles.rol AS rol " +
                "FROM personas INNER JOIN roles ON personas.idRol = roles.id " +
                "WHERE personas.usuario = @usuario AND personas.passwd = @passwd;";

            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion.getConnection()))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@passwd", passwd);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string rol = reader["rol"].ToString();
                            int id = Convert.ToInt32(reader["id"]); // Convertir el ID a entero

                            var result = new Dictionary<string, object>
                    {
                        { "rol", rol },
                        { "id", id }
                    };

                            return result; // Devuelve el diccionario con el rol y el ID del usuario
                        }
                    }
                    else
                    {
                        return new Dictionary<string, object>
                {
                    { "error", "El usuario y/o contraseña son incorrectos" }
                }; // Devuelve un diccionario con un mensaje de error
                    }
                }
            }

            return new Dictionary<string, object>
    {
        { "error", "El usuario y/o contraseña son incorrectos" }
    }; // Devuelve un diccionario con un mensaje de error
        }
        #endregion

        #region Categorias
        public bool agregarCategoria(string categoria)
        {

            string consultaVerificar = "SELECT COUNT(*) FROM categorias WHERE categoria = @categoria";
            string consulta = "INSERT INTO categorias (categoria) VALUES (@categoria)";

            using (MySqlCommand cmdVerificar = new MySqlCommand(consultaVerificar, conexion.getConnection()))
            {
                cmdVerificar.Parameters.AddWithValue("@categoria", categoria);
                int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (count > 0)
                {

                    return false;
                }
            }

            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion.getConnection()))
            {
                cmd.Parameters.AddWithValue("@categoria", categoria);
                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
        }

        public List<Entidad.Categoria> getCategorias()
        {
            List<Entidad.Categoria> listaCategorias = new List<Entidad.Categoria>();
            string consulta = "SELECT * FROM categorias";

            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion.getConnection()))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string nombre = reader.GetString("categoria");

                        Entidad.Categoria categoria = new Entidad.Categoria
                        {
                            Id = id,
                            Categorias = nombre
                        };

                        listaCategorias.Add(categoria);
                    }
                }
            }

            return listaCategorias;
        }
        #endregion

        #region Productos
        public bool guardarProductos(string codigo, string nombre, double precioUnitario,
            double precioMayoreo, double precioTemporada, int idCategoria, int stock, string descripcion)
        {
            string consultaVerificar = "SELECT COUNT(*) FROM productos WHERE nombre = @nombre";
            string consulta = "INSERT INTO productos (nombre, precioUnitario," +
                "precioMayoreo,precioTemporada,stock,idCategoria, codigo,descripcion) " +
                "VALUES (@nombre,@precioUnitario,@precioMayoreo,@precioTemporada," +
                "@stock,@idCategoria,@codigo,@descripcion)";

            using (MySqlCommand cmdVerificar = new MySqlCommand(consultaVerificar,conexion.getConnection()))
            {
                cmdVerificar.Parameters.AddWithValue("@nombre", nombre);
                int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (count > 0)
                {

                    return false;
                }
            }

            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion.getConnection()))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                cmd.Parameters.AddWithValue("@precioMayoreo", precioMayoreo);
                cmd.Parameters.AddWithValue("@precioTemporada", precioTemporada);
                cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
        }

        public List<Productos> getProductos()
        {
            List<Productos> listaProductos = new List<Productos>();
            string consulta = "SELECT productos.id,productos.codigo," +
                " productos.nombre, productos.descripcion, categorias.categoria," +
                " productos.precioUnitario, productos.precioMayoreo, productos.precioTemporada," +
                " productos.stock FROM productos" +
                " INNER JOIN categorias" +
                " ON productos.idCategoria = categorias.id;";

            using (MySqlCommand cmd = new MySqlCommand(consulta, conexion.getConnection()))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string codigo = reader.GetString("codigo");
                        string nombre = reader.GetString("nombre");
                        string descripcion = reader.GetString("descripcion");
                        string categoria = reader.GetString("categoria");
                        double precioUnitario = reader.GetDouble("precioUnitario");
                        double precioMayoreo = reader.GetDouble("precioMayoreo");
                        double precioTemporada = reader.GetDouble("precioTemporada");
                        int stock = reader.GetInt32("stock");

                        Entidad.Productos producto = new Entidad.Productos
                        {
                            Id = id,
                            Codigo = codigo,
                            Nombre = nombre,
                            Descripcion = descripcion,
                            Categoria = categoria,
                            PrecioUnitario = precioUnitario,
                            PrecioMayoreo = precioMayoreo,
                            PrecioTemporada = precioTemporada,
                            Stock = stock
                        };

                        listaProductos.Add(producto);
                    }
                }
                return listaProductos;
            }

            
        }

        /*public DataTable getProductosData()
        {
            string consulta = "SELECT productos.id,productos.codigo," +
                " productos.nombre, productos.descripcion, categorias.categoria," +
                " productos.precioUnitario, productos.precioMayoreo, productos.precioTemporada," +
                " productos.stock FROM productos" +
                " INNER JOIN categorias" +
                " ON productos.idCategoria = categorias.id;";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion.getConecction());
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);

            return dataTable;
        }*/

        public DataTable getProductosData()
        {
            string consulta = "SELECT productos.id, productos.codigo, " +
                              "productos.nombre, productos.descripcion, categorias.categoria, " +
                              "productos.precioUnitario, productos.precioMayoreo, productos.precioTemporada, " +
                              "productos.stock FROM productos " +
                              "INNER JOIN categorias ON productos.idCategoria = categorias.id;";

            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conn = conexion.getConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }

            return dataTable;
        }

        public Productos busquedaProducto(string codigo)
        {
            string consulta = "SELECT codigo, nombre, descripcion, categoria, precioUnitario, precioMayoreo, precioTemporada " +
                              "FROM productos " +
                              "INNER JOIN categorias " +
                              "ON productos.idCategoria = categorias.id " +
                              "WHERE productos.codigo = @codigo;";
            Entidad.Productos productos = null;

            using (MySqlCommand cmd = new MySqlCommand(consulta,conexion.getConnection()))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string codigoBase = reader.GetString("codigo");
                        string nombre = reader.GetString("nombre");
                        string descripcion = reader.GetString("descripcion");
                        string categoria = reader.GetString("categoria");
                        double precioUnitario = reader.GetDouble("precioUnitario");
                        double precioMayoreo = reader.GetDouble("precioMayoreo");
                        double precioTemporada = reader.GetDouble("precioTemporada");

                        productos = new Entidad.Productos
                        {
                            Codigo = codigoBase,
                            Nombre = nombre,
                            Descripcion = descripcion,
                            Categoria = categoria,
                            PrecioUnitario = precioUnitario,
                            PrecioMayoreo = precioMayoreo,
                            PrecioTemporada = precioTemporada
                        };
                    }
                }
            }
            return productos;
        }


        #endregion

        #region Personas
        #endregion

        #region Clientes
        #endregion

        #region Compra
        #endregion

        #region Venta y detalles
        public void Venta(int idCliente, int idPersona, double total, List<Productos> productos)
        {
            using (MySqlConnection connection = conexion.getConnection())
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Paso 1: Insertar la venta y obtener el id de la venta insertada
                        string insertVentaQuery = "INSERT INTO ventas (idCliente, idPersona, total) VALUES (@idCliente, @idPersona, @total); SELECT LAST_INSERT_ID();";
                        int idVenta;

                        using (MySqlCommand insertVentaCommand = new MySqlCommand(insertVentaQuery, connection, transaction))
                        {
                            insertVentaCommand.Parameters.AddWithValue("@idCliente", idCliente);
                            insertVentaCommand.Parameters.AddWithValue("@idPersona", idPersona);
                            insertVentaCommand.Parameters.AddWithValue("@total", total);

                            idVenta = Convert.ToInt32(insertVentaCommand.ExecuteScalar());
                        }

                        // Paso 2: Insertar los detalles de la venta
                        string insertDetalleQuery = "INSERT INTO detalleVentas (idVenta, idProducto, cantidad, precio) VALUES (@idVenta, @idProducto, @cantidad, @precio);";
                        using (MySqlCommand insertDetalleCommand = new MySqlCommand(insertDetalleQuery, connection, transaction))
                        {
                            insertDetalleCommand.Parameters.AddWithValue("@idVenta", idVenta);
                            insertDetalleCommand.Parameters.Add("@idProducto", MySqlDbType.Int32);
                            insertDetalleCommand.Parameters.Add("@cantidad", MySqlDbType.Int32);
                            insertDetalleCommand.Parameters.Add("@precio", MySqlDbType.Decimal);

                            foreach (var producto in productos)
                            {
                                insertDetalleCommand.Parameters["@idProducto"].Value = producto.Id;
                                insertDetalleCommand.Parameters["@cantidad"].Value = producto.Cantidad;
                                insertDetalleCommand.Parameters["@precio"].Value = producto.PrecioUnitario;

                                insertDetalleCommand.ExecuteNonQuery();
                            }
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revertir la transacción en caso de error
                        transaction.Rollback();
                        string mensaje = "Error: " + ex.Message;
                        Console.WriteLine(mensaje); // O maneja el error de otra forma adecuada
                    }
                }
            }
        }


        #endregion
        #region Proveedor
        #endregion
        /*  public List<Productos> productos()
  {
      List<Productos> productos = new List<Productos>();
      return productos;
  }

  public Productos productoVenta(string codigo) { 

      Productos productos = new Productos();
      return productos;
  }*/
    }
}
