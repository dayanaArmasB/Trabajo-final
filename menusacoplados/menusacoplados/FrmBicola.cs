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
    public partial class FrmBicola : Form
    {
        public FrmBicola()
        {
            InitializeComponent();
        }
        //crendo instancia de clase Bicola
        Bicola bicola;

        private void Form4_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top= 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bicola = new Bicola();
            MessageBox.Show("Bicola creada con éxito", "Bicolas",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEncDer_Click(object sender, EventArgs e)
        {
            bicola.EncolarDerecha(int.Parse(txtDato.Text));
            limpiar(sender, e);
        }

        private void btnEncIzq_Click(object sender, EventArgs e)
        {
            bicola.EncolarIzquierda(int.Parse(txtDato.Text));
            limpiar(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                bicola.buscar(int.Parse(txtDato.Text));
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bicola.modificar(int.Parse(txtDato.Text), int.Parse(txtNuevo.Text));
            btnVerBicola_Click(sender, e);
        }

        private void btnDelIzq_Click(object sender, EventArgs e)
        {
            bicola.desencolarI();
            btnVerBicola_Click(sender, e);
        }

        private void btnDelDer_Click(object sender, EventArgs e)
        {
            bicola.desencolarD();
            btnVerBicola_Click(sender, e);
        }

        private void btnVerBicola_Click(object sender, EventArgs e)
        {
            txtBicola.Text = "";
            bicola.verBicola(txtBicola);
        }
        private void limpiar(object sender, EventArgs e)
        {
            //txtBicola.Text = "";
            txtDato.Text = "";
            txtDato.Focus();
            btnVerBicola_Click(sender, e);
        }
    }
}
