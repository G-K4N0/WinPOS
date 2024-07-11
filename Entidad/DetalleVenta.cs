using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetalleVenta
    {
        private int _id {  get; set; }
        private int _idVenta { get; set; }
        private int _idProducto {  get; set; }
        private int _cantidad { get; set; }
        private double _precio { get; set; }

        public DetalleVenta(int id, int idVenta, int idProducto, int cantidad, double precio)
        {
            _id = id;
            _idVenta = idVenta;
            _idProducto = idProducto;
            _cantidad = cantidad;
            _precio = precio;
        }
    }
}
