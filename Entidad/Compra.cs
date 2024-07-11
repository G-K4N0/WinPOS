using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Compra
    {
        private int _id {  get; set; }
        private int _idProducto { get; set; }
        private int _idProveedor { get; set; }
        private int _idPersona { get; set; }
        private int _cantidad { get; set; }
        private double _total { get; set; }
        public Compra(int id, int idProducto, int idProveedor, int idPersona, int cantidad, double total) {
            _id = id;
            _idProducto = idProducto;
            _idProveedor = idProveedor;
            _idPersona = idPersona;
            _cantidad = cantidad;
            _total = total;
        }
    }
}
