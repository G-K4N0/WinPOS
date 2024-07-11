using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {
        private int _id {  get; set; }
        private string _name { get; set; }
        private string _apellido { get; set; }
        private string _telefono {  get; set; }
        private double _deuda {  get; set; }

        public Cliente(int id, string name, string apellido, string telefono, double deuda) {
            _id = id;
            _name = name;
            _apellido = apellido;
            _telefono = telefono;
            _deuda = deuda;
        }
    }
}
