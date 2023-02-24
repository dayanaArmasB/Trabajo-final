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
    public partial class FrmDijkstra1 : Form
    {
        public FrmDijkstra1()
        {
            InitializeComponent();
        }
        
        int inicio = 0;int final = 0;int distancia = 0; int n = 0; int m = 0; int actual = 0;int columna = 0;int[,] tabla; int nodo = 0;
        GrafoDijkstra1 grafo = new GrafoDijkstra1(7);

        private void btnAddArista_Click(object sender, EventArgs e)
        {
            int nodoIni = int.Parse(txtIniNodo.Text);
            int nodoFin = int.Parse(txtFinNodo.Text);
            int peso = int.Parse(txtPesoNodo.Text);
            grafo.AdicionarArista(nodoIni, nodoFin, peso);
            listBox1.Items.Add(nodoIni + " | " + nodoFin + " | " + peso);
        }

        private void btnMostrarAdyacencia_Click(object sender, EventArgs e)
        {
            grafo.MostrarAdyacencia(txtAdyacencia);
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
          
            List<int> ruta = new List<int>();
            int nodo = final;
            while (nodo != inicio)
            {
                ruta.Add(nodo);
                nodo = tabla[nodo, 2];
            }
            ruta.Add(inicio);
            ruta.Reverse();
            foreach (int posicion in ruta)
                txtRutaCorta.Text += posicion + " → ";

        }

        private void btnVerDistancia_Click(object sender, EventArgs e)
        {

            inicio = int.Parse(txtIniDistancia.Text);
            final = int.Parse(txtFinDistancia.Text);
            tabla = new int[7, 3];
            for (n = 0; n < 7; n++)
            {
                tabla[n, 0] = 0;
                tabla[n, 1] = 99; 
                tabla[n, 2] = 0;
            }
            tabla[inicio, 1] = 0;
            MostrarTabla(tabla);
           
            txtDistancia.Text += "\n*******************\n";
            txtDistancia.Text += "\nDistancias luego de Dijkstra\n";
            actual = inicio;
            do
            {
                tabla[actual, 0] = 1;
                for (columna = 0; columna < 7; columna++)
                {
                    if (grafo.ObtenAdyacencia(actual, columna) != 0)
                    {
                        distancia = grafo.ObtenAdyacencia(actual, columna) + tabla[actual, 1];
                        if (distancia < tabla[columna, 1])
                        {
                            tabla[columna, 1] = distancia;
                            tabla[columna, 2] = actual;
                        }
                    }
                }
                int indiceMenor = -1;
                int distanciaMenor = 99;
                for (int x = 0; x < 7; x++)
                {
                    if (tabla[x, 1] < distanciaMenor && tabla[x, 0] == 0)
                    {
                        indiceMenor = x;
                        distanciaMenor = tabla[x, 1];
                    }
                    actual = indiceMenor;
                }
            } while (actual != -1);
       
            MostrarTabla(tabla);
           
        }
        private void MostrarTabla(int[,] aTabla)
        {
            int n = 0;
            for (n = 0; n < aTabla.GetLength(0); n++)
            {
                txtDistancia.Text += n + " → \t" + aTabla[n, 0] +
                "\t" + aTabla[n, 1] + "\t" + aTabla[n, 2] + "\n";
                
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
