using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menusacoplados
{
    internal class GrafoDijkstra1
    {
        int[,] mAdyacencia;
        int nodos;
        public GrafoDijkstra1(int aNodos)
        {
            nodos = aNodos;
            mAdyacencia = new int[nodos, nodos];
        }

        public void AdicionarArista(int aNodoIni, int aNodoFin, int aPeso)
        {
            mAdyacencia[aNodoIni, aNodoFin] = aPeso;
        }

        public void MostrarAdyacencia(RichTextBox txtJesus)
        {
            for (int n = 0; n < nodos; n++)
                txtJesus.Text += "\t" + n;
            txtJesus.Text += "\n";
            for (int n = 0; n < nodos; n++)
            {
                txtJesus.Text += n + "\t";
                for (int m = 0; m < nodos; m++)
                {
                    txtJesus.Text += mAdyacencia[n, m] + "\t";
                }
                txtJesus.Text += "\n";
            }
        }
        public int ObtenAdyacencia(int aFila, int aColumna)
        {
            return mAdyacencia[aFila, aColumna];
        }
    }
}
