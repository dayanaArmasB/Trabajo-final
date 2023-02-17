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
    public partial class FrmMenu : Form
    {
        FrmPilas P1 =new FrmPilas();
        FrmCola C1 = new FrmCola();
        FrmBicola B1 = new FrmBicola();
        FrmListaSimple l1 = new FrmListaSimple();
        FrmListasCiruclares l2 = new FrmListasCiruclares();
        FrmArrayList l3 = new FrmArrayList();
        Autores au = new Autores();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            P1.MdiParent = this;
            C1.MdiParent = this;
            B1.MdiParent = this;
            l1.MdiParent = this; 
            l2.MdiParent = this; 
            l3.MdiParent = this;
            au.MdiParent = this;
        }

        private void conPilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Show();
            C1.Hide();
            B1.Hide();
            l1.Hide();
            l2.Hide();
            l3.Hide();
        }

        private void conHilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Show();
            B1.Hide();
            l1.Hide();
            l2.Hide();
            l3.Hide();
        }

        private void conSeñalizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Show();
            l1.Hide();
            l2.Hide();
            l3.Hide();
        }


        private void aplicacionnesXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            l1.Show();
            l2.Hide();
            l3.Hide();
        }

        private void listaEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            l1.Hide();
            l2.Show();
            l3.Hide();
        }

        private void arrayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            l1.Hide();
            l2.Hide();
            l3.Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            au.Show();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
