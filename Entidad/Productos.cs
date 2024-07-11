using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Productos
    {
        private int _id {  get; set; }
        private string _name { get; set; }
        private string _description { get; set; }
        private double _precioUnitario { get; set; }
        private double _precioMayoreo {  get; set; }
        private double? _precioTemporada { get; set; }
        private int _stock {  get; set; }
        private int _idCategoria { get; set; }

        private string _categoria { get; set; }
        public Productos(int id, string name, string descripcion,
            double precioUnitario, double precioMayoreo, double precioTemporada,
            int stock, int idCategoria) { 
            _id = id;
            _name = name;
            _description = descripcion;
            _precioUnitario = precioUnitario;
            _precioMayoreo = precioMayoreo;
            _precioTemporada = precioTemporada;
            _stock = stock;
            _idCategoria = idCategoria;
        }

        public Productos(int id, string name, string descripcion,
            double precioUnitario, double precioMayoreo, double precioTemporada,
            int stock, string Categoria)
        {
            _id = id;
            _name = name;
            _description = descripcion;
            _precioUnitario = precioUnitario;
            _precioMayoreo = precioMayoreo;
            _precioTemporada = precioTemporada;
            _stock = stock;
            _categoria = Categoria;
        }
    }
}
