using System;
using System.Collections;
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
    public partial class FrmListasCiruclares : Form
    {
        public FrmListasCiruclares()
        {
            InitializeComponent();
        }
        Lista objLista;

        private void ListaEnlazada_Load(object sender, EventArgs e)
        {

        }


        private void FrmListasCiruclares_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            objLista.insertar(txtDato.Text);
            txtDato.Text = "";
            txtDato.Focus();
            btn_Verlista_Click(sender, e);
        }

        private void btn_Verlista_Click(object sender, EventArgs e)
        {
            txtLista.Text = "";
            objLista.verlista(txtLista);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            objLista.buscar(txtDato.Text);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            objLista.eliminar(txtDato.Text);
            txtDato.Text = "";
        }

        private void btn_Modifcar_Click(object sender, EventArgs e)
        {
            string persona = (txtDato.Text);
            string nuevo = (txtNuevoDato.Text);
            objLista.modificar(persona, nuevo);
            btn_Verlista_Click(sender, e);
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            objLista = new Lista();
            MessageBox.Show("Lista creada con exito ", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
