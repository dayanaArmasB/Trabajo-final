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
        FrmListaSimple L1 = new FrmListaSimple();
        FrmListasCiruclares LC = new FrmListasCiruclares();
        FrmArrayList AL = new FrmArrayList();
        FrmLinqXml Xml = new FrmLinqXml();
        FrmArbol2 T2 = new FrmArbol2();
        FrmArbol1 T1 = new FrmArbol1();
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
            L1.MdiParent = this;
            LC.MdiParent = this;
            AL.MdiParent = this;
            Xml.MdiParent = this;
            T2.MdiParent = this;
            au.MdiParent = this;
        }

        private void conPilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Show();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            LC.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
        }

        private void conHilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Show();
            B1.Hide();
            L1.Hide();
            LC.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
        }

        private void conSeñalizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Show();
            L1.Hide();
            LC.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
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
            L1.Show();
            LC.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
        }

        private void listaEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            LC.Show();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
        }

        private void arrayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            LC.Hide();
            AL.Show();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
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

        private void p3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            LC.Hide();
            AL.Hide();
            Xml.Show();
            T2.Hide();
            T1.Hide();
        }

        private void Arbol2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            LC.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Show();
            T1.Hide();
        }

        private void Arbol1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            LC.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Show();
        }
    }
}
