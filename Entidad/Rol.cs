using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Rol
    {
        private int _id {  get; set; }
        private string _rol {  get; set; }
        public Rol(int id, string rol) { 
            _id = id;
            _rol = rol;
        }
    }
}
