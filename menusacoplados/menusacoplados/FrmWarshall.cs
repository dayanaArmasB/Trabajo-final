using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menusacoplados
{
    public partial class FrmWarshall : Form
    {
        public FrmWarshall()
        {
            InitializeComponent();
        }
        public const int inf = 99;
        string[] nodos = { "A", "B", "C", "D", "E" };
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] grapho =
         {
                { 0, 4, 8, inf, inf },
                { 4, 0, 1, 2, inf },
                { 8, inf, 0, 4, 2 },
                { inf, 2, 4, 0, 7 },
                { inf, inf, 2, 7, 0 }
            };
            verGrafo(grapho);
            FloydWarshall(grapho, 5);
        }

        private void FloydWarshall(int[,] grafo, int nNodos)
        {
            int[,] distancia = new int[nNodos, nNodos];
            for (int i = 0; i < nNodos; i++)
                for (int j = 0; j < nNodos; j++)
                    distancia[i, j] = grafo[i, j];
            for (int k = 0; k < nNodos; k++)
            {
                for (int i = 0; i < nNodos; i++)
                {
                    for (int j = 0; j < nNodos; j++)
                    {
                        if (distancia[i, k] + distancia[k, j] < distancia[i, j])
                            distancia[i, j] = distancia[i, k] + distancia[k, j];
                    }
                }
            }
            verNuevasDistancias(distancia, nNodos);
        }
        private void verNuevasDistancias(int[,] distancia, int nNodos)
        {
            for (int i = 0; i < nodos.Length; i++)
                txtMatriz2.Text += "\t" + nodos[i];
            txtMatriz2.Text += "\n";
            for (int i = 0; i < nNodos; i++)
            {
                txtMatriz2.Text += nodos[i] + "\t"; for (int j = 0; j < nNodos; j++)
                    txtMatriz2.Text += distancia[i, j] + "\t"; txtMatriz2.Text += "\n";
            }
        }
        private void verGrafo(int[,] grafo)
        {
            for (int i = 0; i < nodos.Length; i++)
                txtMatriz1.Text += "\t" + nodos[i];
            txtMatriz1.Text += "\n";
            for (int i = 0; i < nodos.Length; i++)
            {
                txtMatriz1.Text += nodos[i] + "\t";
                for (int j = 0; j < nodos.Length; j++)
                    txtMatriz1.Text += grafo[i, j] + "\t"; txtMatriz1.Text += "\n";
            }
        }
    }
}
