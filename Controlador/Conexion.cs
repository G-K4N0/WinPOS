using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Controlador
{
    public class Conexion
    {
        private MySqlConnection _connection;
        private string server = "localhost";
        private string username = "root";
        private string password = "TalentoUnido";
        private string database = "papeleriadb";
        private string cadenaConexion;
        public Conexion()
        {
            cadenaConexion = "SERVER=" + server
                + "; DATABASE=" + database
                + "; UID=" + username
                + "; PASSWORD=" + password + ";";
        }
        public MySqlConnection getConnection()
        {
            if (_connection == null)
            {
                try
                {
                    _connection = new MySqlConnection(cadenaConexion);
                    _connection.Open();
                }
                catch (MySqlException ex)
                {
                    // Manejo de excepciones (log, rethrow, etc.)
                    Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                    throw;
                }
            }
            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection != null)
            {
                try
                {
                    _connection.Close();
                    _connection = null;
                }
                catch (MySqlException ex)
                {
                    // Manejo de excepciones (log, etc.)
                    Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
                }
            }
        }

    }
}
