using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Categoria
    {
        private int _id { get; set; }
        private string _name { get; set; }

        public Categoria(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
