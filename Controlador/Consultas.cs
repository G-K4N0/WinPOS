using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Controlador
{
    public  class Consultas
    {
        Conexion conexion;
        public Consultas() {
        conexion = new Conexion();
        }

        public List<Productos> productos()
        {
            List<Productos> productos = new List<Productos>();
            return productos;
        }

        public Productos productoVenta(string codigo) { 
        
            Productos productos = new Productos();
            return productos;
        }
    }
}
