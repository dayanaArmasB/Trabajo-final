using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menusacoplados
{
    internal class NodoBicola
    {
        public int dato;
        public NodoBicola anterior;
        public NodoBicola siguiente;

        public NodoBicola(int dat, NodoBicola ant, NodoBicola sig)
        {
            dato = dat;
            anterior = ant;
            siguiente = sig;
        }
    }
}
