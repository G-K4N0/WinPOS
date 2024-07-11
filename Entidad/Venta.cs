using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Venta
    {
        private int _id;
        private int _idCliente;
        private int _idPersona;
        private DateTime _fecha;
        private double _total;

        public Venta(int id, int idCliente, int idPersona, DateTime fecha, double total)
        {
            _id = id;
            _idCliente = idCliente;
            _idPersona = idPersona;
            _fecha = fecha;
            _total = total;
        }
    }
}
