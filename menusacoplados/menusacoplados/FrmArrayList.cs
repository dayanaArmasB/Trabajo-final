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
    public partial class FrmArrayList : Form
    {
        public FrmArrayList()
        {
            InitializeComponent();
        }

        Producto producto = new Producto();
        ArrayList listado = new ArrayList();
        int pos;//Para tomar la posicion dela fila seleccionada en el DGW

        void limpiar()
        {
            txtcodigo.Text = "";
            txtProducto.Text = "";
            txtReferencia.Text = "";
            txtPrecio.Text = "";
            txtcodigo.Focus();
        }

        private void ArrayList_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void ArrayList_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto.Codigo = int.Parse(txtcodigo.Text);
            producto.Nombre = txtProducto.Text;
            producto.Referencia = txtReferencia.Text;
            producto.Precio = double.Parse(txtPrecio.Text);
            listado.Add(producto);
            
            dgw.Rows.Add(producto.Codigo, producto.Nombre,
            producto.Referencia, producto.Precio);
            MessageBox.Show("Producto Registrado", "Mensaje");
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            producto.Codigo = int.Parse(txtcodigo.Text);
            producto.Nombre = txtProducto.Text;
            producto.Referencia = txtReferencia.Text;
            producto.Precio = double.Parse(txtPrecio.Text);
            dgw[0, pos].Value = producto.Codigo;
            dgw[1, pos].Value = producto.Nombre;
            dgw[2, pos].Value = producto.Referencia;
            dgw[3, pos].Value = producto.Precio;
            MessageBox.Show("Producto  Modificado", "Mensaje");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgw.Rows.RemoveAt(pos);
            listado.Remove(pos);
            MessageBox.Show("Producto Eliminado", "Mensaje");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double st = 0;
            if (dgw.Rows.Count == 0)
            {
                MessageBox.Show("No existen Productos");
                return;
            }
            for (pos = 0; pos <= dgw.Rows.Count - 1; pos++)
            {
                st = st + Convert.ToDouble(dgw[3, pos].Value);
            }
            dgw.Rows.Add("", "", "Total a pagar", st);
        }

        private void dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dgw.CurrentRow.Index;
            txtcodigo.Text = dgw[0, pos].Value.ToString();
            txtProducto.Text = dgw[1, pos].Value.ToString();
            txtReferencia.Text = dgw[2, pos].Value.ToString();
            txtPrecio.Text = dgw[3, pos].Value.ToString();
        }
    }
}
