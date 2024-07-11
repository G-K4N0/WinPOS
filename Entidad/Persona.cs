using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _user { get; set; }
        public string _passwd { get; set; }
        public string _rol { get; set; }
        public int _idRol { get; set; }
        public Persona(int id, string name, string user, string passwd, string rol) {
            _id = id;
            _name = name;
            _user = user;
            _passwd = passwd;
            _rol = rol;
        }
        public Persona(int id, string name, string user, string passwd, int idRol) {
            _id = id;
            _name = name;
            _user = user;
            _passwd = passwd;
            _idRol = idRol;
        }

    }
}
