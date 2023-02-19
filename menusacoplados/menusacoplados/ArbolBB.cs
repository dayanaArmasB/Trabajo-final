using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menusacoplados
{
    internal class ArbolBB
    {
        class Nodo
        {
            public int dato;
            public Nodo izq, der;
        }
        Nodo raiz;
        public ArbolBB()
        {
            raiz = null;
        }
        public void insertar(int dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = dato;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                Nodo anterior = null;
                Nodo reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (dato < reco.dato)//dato.Equals(reco.dat)==-1
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (dato < anterior.dato)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }
        private string recorridoPre(Nodo reco, ref string cad)
        {
            if (reco != null)
            {
                cad += reco.dato + " ";
                recorridoPre(reco.izq, ref cad);
                recorridoPre(reco.der, ref cad);
            }
            return cad;
        }
        public string recorridoPre()
        {
            string cad = "";
            return recorridoPre(this.raiz, ref cad);
        }

        public string recorridoIn()
        {
            string cad = " ";
            return recorridoIn(this.raiz, ref cad);
        }
        private string recorridoIn(Nodo reco, ref string cad)
        {
            if (reco != null)
            {
                recorridoIn(reco.izq, ref cad);
                cad += reco.dato + " ";
                recorridoIn(reco.der, ref cad);
            }
            return cad;
        }
        public string recorridoPost()
        {
            string cad = " ";
            return recorridoPost(this.raiz, ref cad);
        }
        private string recorridoPost(Nodo reco, ref string cad)
        {
            if (reco != null)
            {
                recorridoPost(reco.izq, ref cad);
                recorridoPost(reco.der, ref cad);
                cad += reco.dato + " ";
            }
            return cad;
        }
    }
}
