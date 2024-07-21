using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Productos
    {
        private int _id;
        public int Id {  get; set; }
        private string _nombre;
        public string Nombre{ get; set; }
        private string _description;
        public string Descripcion { get; set; }
        private double _precioUnitario;
        public double PrecioUnitario{ get; set; }

        private double _precioMayoreo;
        public double PrecioMayoreo {  get; set; }
        private double? _precioTemporada;
        public double? PrecioTemporada { get; set; }
        private int _stock;
        public int Stock {  get; set; }
        private int _idCategoria;
        public int IdCategoria { get; set; }

        private string _categoria;
        public string Categoria { get; set; }
        private string _codigo;
        public string Codigo { get; set; } = null;

        private int _cantidad;
        public int Cantidad { get; set; }
        private double _subtotal;
        public double Subtotal { get; set; }

        public Productos(int id, string codigo, string name, string descripcion,
            double precioUnitario, double precioMayoreo, double precioTemporada,
            int stock, int idCategoria) { 
            _id = id;
            _codigo = codigo;
            _nombre = name;
            _description = descripcion;
            _precioUnitario = precioUnitario;
            _precioMayoreo = precioMayoreo;
            _precioTemporada = precioTemporada;
            _stock = stock;
            _idCategoria = idCategoria;
        }
        public Productos(int id,string codigo, string name, string descripcion,
            double precioUnitario, double precioMayoreo, double precioTemporada,
            int stock, string Categoria)
        {
            _id = id;
            _codigo = codigo;
            _nombre = name;
            _description = descripcion;
            _precioUnitario = precioUnitario;
            _precioMayoreo = precioMayoreo;
            _precioTemporada = precioTemporada;
            _stock = stock;
            _categoria = Categoria;
        }
        public Productos(string codigo, string name, string descripcion, string categoria, double precioUnitario, double precioMayoreo, double precioTemporada) {
            _codigo = codigo;
            _nombre = name;
            _description = descripcion;
            _categoria = categoria;
            _precioUnitario = precioUnitario;
            _precioMayoreo= precioMayoreo;
            _precioTemporada= precioTemporada;
        }

        public Productos(int id,string nombre, double precio, int cantidad, double subtotal)
        {
            _id= id;
            _nombre = nombre;
            _precioUnitario= precio;
            _cantidad= cantidad;
            _subtotal= subtotal;
        }
        public Productos() { }
    }
}
