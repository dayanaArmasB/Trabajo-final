using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace menusacoplados
{
    public class Producto
    {
        private int codigo;
        private string nombre;
        private double precio;
        private string referencia;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Referencia { get => referencia; set => referencia = value; }
    }
}
