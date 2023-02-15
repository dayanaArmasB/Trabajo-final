using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menusacoplados
{
    public  class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }

        public Persona(string nombre, string apellido, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public Persona()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.telefono = string.Empty;

        }
    }
}
