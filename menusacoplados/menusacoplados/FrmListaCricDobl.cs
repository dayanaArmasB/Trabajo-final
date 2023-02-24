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
    public partial class FrmListaCricDobl : Form
    {
        public FrmListaCricDobl()
        {
            InitializeComponent();
        }
        Lista lista;
        Lista2 lista2;
        private void btn_crear_Click(object sender, EventArgs e)
        {
            lista = new Lista();
            MessageBox.Show("lista creada con exito");
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            txt_mostrar.Clear();
            lista.verLista(txt_mostrar);
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            lista.insertarNodo(int.Parse(txt_dato.Text));
            txt_dato.Clear();
            txt_dato.Focus();


            btn_ver_Click(sender, e);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            lista.buscarNodo(int.Parse(txt_dato.Text));
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lista.eliminarNodo(int.Parse(txt_dato.Text));
            btn_ver_Click(sender, e);
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            //int dato = int.Parse(txt_dato.Text);
            //int dato = int.Parse(txt_dato.Text);

            lista.modificarNodo(int.Parse(txt_dato.Text), int.Parse(txt_modif.Text));

            btn_ver_Click(sender, e);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_crearLista_Click(object sender, EventArgs e)
        {
            lista2 = new Lista2();
            MessageBox.Show("lista creada con exito");
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            lista2.insertar(int.Parse(txt_dato2.Text));
            txt_dato2.Clear();
            txt_dato2.Focus();
        }

        private void btn_verlID_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_ID.Clear();
            lista2.verListaID(listBox1, txt_ID);
        }

        private void btn_verDI_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_DI.Clear();
            lista2.verListaDI(listBox1, txt_DI);
        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {

        }
    }
}
