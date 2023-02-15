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
    public partial class FrmListaSimple : Form
    {
        public FrmListaSimple()
        {
            InitializeComponent();
        }
        Persona contacto;
        List<Persona> listado;
        int pos;//Para tomar la posicion de la fila seleccionada en el DGW

        private void Refresh(List<Persona> ls)
        {
            if (dgw.Rows.Count > 0)
            {
                dgw.DataSource = null;
            }
            dgw.DataSource = ls;
        }
        void limpiar()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_telefono.Clear();
            txt_nombre.Focus();
        }


        private void ListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            {
                listado = new List<Persona>();
                MessageBox.Show("lista creada con exito");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            contacto = new Persona();
            contacto.nombre = txt_nombre.Text;
            contacto.apellido = txt_apellido.Text;
            contacto.telefono = txt_telefono.Text;

            listado.Add(contacto);

            Refresh(listado);
            MessageBox.Show("contacto Registrado", "Mensaje");
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona pers = new Persona();
            pers.telefono = txt_telefono.Text;
            pers.nombre = txt_nombre.Text;
            pers.apellido = txt_apellido.Text;
            int indice = listado.FindIndex(x => x.nombre == txt_nombre.Text);
            if (indice == -1)
            {
                MessageBox.Show("no se enconto el dato dentro de la lista");
            }
            else
            {
                listado[indice] = pers;
                MessageBox.Show("se cambio el dato con exito");
            }
            Refresh(listado);
        }


        private void dgw_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pos = dgw.CurrentRow.Index;
            txt_nombre.Text = dgw[0, pos].Value.ToString();
            txt_apellido.Text = dgw[1, pos].Value.ToString();
            txt_telefono.Text = dgw[2, pos].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = listado.FindIndex(x => x.nombre == txt_nombre.Text);
            if (indice == -1)
            {
                MessageBox.Show("no se enconto el contacto dentro de la lista");
            }
            else
            {
                listado.RemoveAt(indice);
                MessageBox.Show("contacto Eliminado", "Mensaje");
            }
            Refresh(listado);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int indice = listado.FindIndex(x => x.nombre == (txt_nombre.Text));
            if (indice == -1)
            {
                MessageBox.Show("el contacto no existe en la lista");
            }
            else
            {
                MessageBox.Show("el contacto fue encontrado con exito");
                this.dgw.Rows[indice].DefaultCellStyle.BackColor = Color.Gray;
            }
            Refresh(listado);
        }

        private void btn_mezclar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listado.Count > 0)
                {
                    var rnd = new Random();
                    dgw.DataSource = listado.OrderBy(item => rnd.Next()).ToList();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmListaSimple_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
    }
}
