using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menusacoplados
{
    internal class NodoArbol
    {
        private string dato;
        private NodoArbol hijo;
        private NodoArbol hermano;

        public string Dato { get => dato; set => dato = value; }
        internal NodoArbol Hijo { get => hijo; set => hijo = value; }
        internal NodoArbol Hermano { get => hermano; set => hermano = value; }

        public NodoArbol()
        {
            Dato = "";
            Hijo = null;
            Hermano = null;
        }
    }
}
