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
using System.Xml;

namespace menusacoplados
{
    public partial class FrmCola : Form
    {
        public FrmCola()
        {
            InitializeComponent();
        }
        //objeto para la cola principal
        Queue cola = new Queue();

        //objeto para la cola auxiliar
        Queue colax = new Queue();

        private void Form3_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            cola.Enqueue(txtDato.Text);
            txtDato.Text = "";
            txtDato.Focus();
            btnVerCola_Click(sender, e);
        }

        private void btnVerCola_Click(object sender, EventArgs e)
        {
            txtCola.Text = "";
            foreach (string element in cola)
                txtCola.Text += element + " ";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cola.Contains(txtDato.Text))
                MessageBox.Show(txtDato.Text + " está en la cola", "Colas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(txtDato.Text + " NO está en la cola", "Colas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cola.Contains(txtDato.Text))
            {
                foreach (string element in cola)
                    if (element != txtDato.Text)
                        colax.Enqueue(element);
                cola = new Queue();
                foreach (string element in colax)
                    cola.Enqueue(element);
                colax = new Queue();
                btnVerCola_Click(sender, e);
            }
            else
            {
                MessageBox.Show(txtDato.Text + " NO está en la cola", "Colas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cola.Contains(txtDato.Text))
            {
                foreach (string element in cola)
                {
                    if (element == txtDato.Text)
                        colax.Enqueue(txtNuevo.Text);
                    else
                        colax.Enqueue(element);
                }
                cola = new Queue();
                foreach (string element in colax)
                    cola.Enqueue(element);
                colax = new Queue();
                btnVerCola_Click(sender, e);
            }
            else
            {
                MessageBox.Show(txtDato.Text + " NO está en la cola", "Colas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            cola.Dequeue();
            btnVerCola_Click(sender, e);
        }
    }
}
