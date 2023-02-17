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
    public partial class FrmArbol2 : Form
    {
        public FrmArbol2()
        {
            InitializeComponent();
        }

        private void FrmArbol2_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        Arbol arbol = new Arbol();
        NodoArbol raiz;

        private void btnInsComoRaiz_Click(object sender, EventArgs e)
        {
            raiz = arbol.insertar(txtDato.Text, null);
            btnRecPreOrd_Click(sender, e);
        }

        private void btnInsEnRaiz_Click(object sender, EventArgs e)
        {
            txtArbol1.Text = "";
            arbol.insertar(txtDato.Text, raiz);
            arbol.recorridoPreO(raiz, txtArbol1);
        }

        private void btnInsEnNodo_Click(object sender, EventArgs e)
        {
            string enNodo = txtEnNodo.Text;
            string elDato = txtDato.Text;
            NodoArbol encontrado = arbol.buscar(enNodo, raiz);
            arbol.insertar(elDato, encontrado);
            arbol.recorridoPreO(raiz, txtArbol1);
            btnRecPreOrd_Click(sender, e);
        }

        private void btnRecPreOrd_Click(object sender, EventArgs e)
        {
            txtArbol1.Text = "";
            arbol.recorridoPreO(raiz, txtArbol1);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtPreOrd.Text = arbol.recPreOrd();
            txtPostOrd.Text = arbol.recPostOrd();
            txtInOrd.Text = arbol.recorridoIn();
        }

        private void btnInsNodo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtNodo.Text);
        }

        private void btnInsElement_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(txtElement.Text);
        }

        private void FrmArbol2_Load(object sender, EventArgs e)
        {

        }
    }
}
