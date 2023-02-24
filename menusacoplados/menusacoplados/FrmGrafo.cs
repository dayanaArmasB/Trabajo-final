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
    public partial class FrmGrafo : Form
    {
        public FrmGrafo()
        {
            InitializeComponent();
        }
        int nodo = 0;
        //Grafo grafo = new Grafo(4);
        Grafo grafo;
        private void button2_Click(object sender, EventArgs e)
        {
            grafo.AdicionarArista(int.Parse(txtNodoIni.Text), 
                int.Parse(txtNodoFin.Text));
            listBox1.Items.Add(txtNodoIni.Text + " | " + txtNodoFin.Text);
            txtNodoFin.Clear();
            txtNodoIni.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grafo.MostrarAdyacencia(txtAdyacencia);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grafo.CalcularInDegree();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grafo.VerInDegree(listBox2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            do 
            { 
                nodo = grafo.EncuentraI0(); 
                if (nodo != -1) 
                { 
                    txtOrden.Text += nodo + " => "; 
                    grafo.DecrementaInDegree(nodo); 
                } 
            } 
            while (nodo != -1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grafo = new Grafo(int.Parse(txtNroNodos.Text));
        }
    }
}
