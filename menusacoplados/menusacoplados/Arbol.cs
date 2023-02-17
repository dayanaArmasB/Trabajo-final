using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menusacoplados
{
    internal class Arbol
    {
        private NodoArbol raiz;
        private NodoArbol actual;
        private int i = 0;

        public Arbol()
        {
            raiz = new NodoArbol();
        }

        public NodoArbol insertar(string pDato, NodoArbol pNodo)
        {
            if (pNodo == null)//inserta como raíz
            {
                raiz = new NodoArbol();
                raiz.Dato = pDato;
                raiz.Hijo = null;
                raiz.Hermano = null;
                return raiz;
            }
            if (pNodo.Hijo == null)//inserta como hijo
            {
                NodoArbol temp = new NodoArbol();
                temp.Dato = pDato;
                pNodo.Hijo = temp;
                return temp;
            }
            else //inserta como hermano
            {
                actual = pNodo.Hijo;
                while (actual.Hermano != null)
                {
                    actual = actual.Hermano;
                }
                NodoArbol temp = new NodoArbol();
                temp.Dato = pDato;
                actual.Hermano = temp;
                return temp;
            }
        }
        public void recorridoPreO(NodoArbol pNodo, RichTextBox tree)
        {
            if (pNodo == null)
                return;
            for (int j = 0; j < i; j++)
                tree.Text += " > ";
            tree.Text += pNodo.Dato + "\n";

            if (pNodo.Hijo != null)
            {
                i++;
                recorridoPreO(pNodo.Hijo, tree);
                i--;
            }

            if (pNodo.Hermano != null)
            {
                recorridoPreO(pNodo.Hermano, tree);
            }
        }


        private string recPreOrd(NodoArbol reco, ref string cad)
        {
            if (reco != null)
            {
                cad += reco.Dato + " ";
                recPreOrd(reco.Hijo, ref cad);
                recPreOrd(reco.Hermano, ref cad);
            }
            return cad;
        }
        public string recPreOrd()
        {
            string cad = "";
            return recPreOrd(this.raiz, ref cad);
        }
        //**************************************************//
        private string recPostOrd(NodoArbol reco, ref string cad)
        {
            if (reco != null)
            {
                recPostOrd(reco.Hijo, ref cad);
                recPostOrd(reco.Hermano, ref cad);
                cad += reco.Dato + " ";
            }
            return cad;
        }
        public string recPostOrd()
        {
            string cad = "";
            return recPostOrd(this.raiz, ref cad);
        }
        private string recorridoIn(NodoArbol reco, ref string cad)
        {
            if (reco != null)
            {
                recorridoIn(reco.Hijo, ref cad);
                cad += reco.Dato + " ";
                recorridoIn(reco.Hermano, ref cad);
            }
            return cad;
        }
        public string recorridoIn()
        {
            string cad = " ";
            return recorridoIn(this.raiz, ref cad);
        }
        public NodoArbol buscar(string pDato, NodoArbol pNodo)
        {
            NodoArbol encontrado = null;
            if (pNodo == null)
                return encontrado;
            if (pNodo.Dato.CompareTo(pDato) == 0)
            {
                encontrado = pNodo;
                return encontrado;
            }
            if (pNodo.Hijo != null)
            {
                encontrado = buscar(pDato, pNodo.Hijo);
                if (encontrado != null)
                    return encontrado;
            }
            if (pNodo.Hermano != null)
            {
                encontrado = buscar(pDato, pNodo.Hermano);
                if (encontrado != null)
                    return encontrado;
            }
            return encontrado;
        }
    }
}
