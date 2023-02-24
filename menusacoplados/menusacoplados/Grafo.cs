using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menusacoplados
{
    internal class Grafo
    {
        int[,] mAdyacencia;
        int[] inDegree;
        int nodos;
        public Grafo(int pNodos)
        {
            nodos = pNodos;
            mAdyacencia = new 
                int[nodos, nodos]; 
            inDegree = new int[nodos];
        }
        public void AdicionarArista(int pNodoInicio, int pNodoFinal) 
        { 
            mAdyacencia[pNodoInicio, pNodoFinal] = 1; 
        }
        public void MostrarAdyacencia(RichTextBox txtAdy) 
        { 
            for (int n = 0; n < nodos; n++) 
                txtAdy.Text += "\t" + n; txtAdy.Text += "\n"; 
            for (int n = 0; n < nodos; n++) 
            { txtAdy.Text += n + "\t"; for (int m = 0; m < nodos; m++) 
                { 
                    txtAdy.Text += mAdyacencia[n, m] + "\t"; 
                } 
                txtAdy.Text += "\n"; 
            } 
        }
        public void CalcularInDegree() 
        { 
            for (int n = 0; n < nodos; n++) 
            { 
                for (int m = 0; m < nodos; m++) 
                {
                    if (mAdyacencia[m, n] == 1) inDegree[n]++; 
                } 
            } 
        }
        public void VerInDegree(ListBox lstInDegree) 
        { 
            for (int n = 0; n < nodos; n++) 
                lstInDegree.Items.Add("Nodo " + n + ": " + inDegree[n]); 
        }
        public int EncuentraI0()
        {
            int n; bool encontrado = false; for (n = 0; n < nodos; n++) 
            { 
                if (inDegree[n] == 0) 
                { 
                    encontrado = true; break; 
                } 
            }
            if (encontrado)
                return n; else 
                return - 1;
        }
        public void DecrementaInDegree(int pNodo) 
        { 
            inDegree[pNodo] = -1; 
            for (int n = 0; n < nodos; n++) 
            { 
                if (mAdyacencia[pNodo, n] == 1) inDegree[n]--; 
            }
        }
    }
}
