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
    public partial class FrmArbolBB : Form
    {
        public FrmArbolBB()
        {
            InitializeComponent();
        }
        //creando objeto de la clase ArbolBB
        ArbolBB arbolBB = new ArbolBB();
        //ArbolBB arbolBB;
        private void btn_reset_Click(object sender, EventArgs e)
        {
            arbolBB = new ArbolBB();
            txtPreOrden.Text = "";
            txtInOrden.Text = "";
            txtPostOrden.Text = "";
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            arbolBB.insertar(int.Parse(txtDato.Text));

            txtPreOrden.Text = arbolBB.recorridoPre();
            txtInOrden.Text = arbolBB.recorridoIn();
            txtPostOrden.Text = arbolBB.recorridoPost();

            txtDato.Clear();
            txtDato.Focus();
        }

        private void FrmArbolBB_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
    }
}
