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
    public partial class FrmListaEnlazadaS : Form
    {
        public FrmListaEnlazadaS()
        {
            InitializeComponent();
        }
        
        private void ListaEnlazada_Load(object sender, EventArgs e)
        {

        }


        private void FrmListasCiruclares_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        List<int> edad;

        private void BTN_CREAR_Click(object sender, EventArgs e)
        {

            try
            {
                edad = new List<int>();
                MessageBox.Show("lista creada con exito");
            }
            catch (Exception)
            {

                MessageBox.Show("Cree la lista");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txt_dato.Text);

                edad.Add(dato);

                txt_dato.Clear();
                txt_dato.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("ingrese el tipo de dato correcto");
                txt_dato.Clear();
                txt_dato.Focus();
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txt_dato.Text);

            var indice = edad.FindIndex(x => x == dato);

            btn_ver_Click(sender, e);
            if (indice == -1)
            {
                MessageBox.Show("no se enconto el dato dentro de la lista");
            }
            else
            {
                edad.Remove(dato);
                MessageBox.Show("se elimno el dato con exito");
                btn_ver_Click(sender, e);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            var indice = edad.FindIndex(x => x == int.Parse(txt_dato.Text));
            if (indice == -1)
            {
                MessageBox.Show("el dato no existe en la lista");
            }
            else
            {
                MessageBox.Show("el dato fue encontrado con exito");
                listBox1.SelectedIndex = indice;
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var obj in edad)
            {
                listBox1.Items.Add(obj);
            }
        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            edad.Sort();
            listBox1.Items.Clear();
            foreach (var obj in edad)
            {
                listBox1.Items.Add(obj);
            }

            btn_ver_Click(sender, e);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int dato_actual = int.Parse(txt_dato.Text);
            int dato_nuevo = int.Parse(txt_dato_modif.Text);
            var indice = edad.FindIndex(x => x == dato_actual);


            if (indice == -1)
            {
                MessageBox.Show("no se enconto el dato dentro de la lista");
            }
            else
            {
                edad[indice] = dato_nuevo;
                MessageBox.Show("se cambio el dato con exito");
                btn_ver_Click(sender, e);
            }
        }
    }


}
