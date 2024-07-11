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

        public MySqlConnection getConecction()
        {
            if (_connection == null)
            {
                _connection = new MySqlConnection(cadenaConexion);
                _connection.Open();
            }
            return _connection;
        }
    }
}
