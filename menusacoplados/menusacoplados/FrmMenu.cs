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
        FrmCola1 f3 = new FrmCola1();
        FrmCola2 f4 = new FrmCola2();
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
            f3.MdiParent = this; 
            f4.MdiParent = this;
            l1.MdiParent = this; 
            l2.MdiParent = this; 
            l3.MdiParent = this;
        }

        private void conPilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Show();
            f3.Hide();
            f4.Hide();
            l1.Hide();
            l2.Hide();
            l3.Hide();
        }

        private void conHilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            f3.Show();
            f4.Hide();
            l1.Hide();
            l2.Hide();
            l3.Hide();
        }

        private void conSeñalizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            f3.Hide();
            f4.Show();
            l1.Hide();
            l2.Hide();
            l3.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aplicacionnesXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            au.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            f3.Hide();
            f4.Hide();
            l1.Show();
            l2.Hide();
            l3.Hide();
        }

        private void listaEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Hide();
            f3.Hide();
            f4.Hide();
            l1.Hide();
            l2.Show();
            l3.Hide();
        }

        private void arrayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Hide();
            f3.Hide();
            f4.Hide();
            l1.Hide();
            l2.Hide();
            l3.Show();
        }
    }
}
