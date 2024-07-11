using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Proveedor
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private string _apellido { get; set; }
        private string _telefono { get; set; }
        private string _correo { get; set; }
        public Proveedor(int id, string name, string apellido, string telefono, string correo) {
            _id = id;
            _name = name;
            _apellido = apellido;
            _telefono = telefono;
            _correo = correo;
        }
    }
}
