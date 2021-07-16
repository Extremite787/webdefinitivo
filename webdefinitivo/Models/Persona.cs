using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webdefinitivo.Models
{
    interface Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dirreccion { get; set; }
        public string Genero { get; set; }
    }
}
