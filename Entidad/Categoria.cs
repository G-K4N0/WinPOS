using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Categoria
    {
        private int _id;
        public int Id { get; set; }
        private string _categoria;
        public string Categorias{ get; set; }

        public Categoria(int id, string categoria)
        {
            _id = id;
            _categoria = categoria;
        }
        public Categoria() { }
    }
}
