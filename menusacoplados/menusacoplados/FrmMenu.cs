﻿using System;
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
        FrmListaEnlazadaS L2 = new FrmListaEnlazadaS();
        FrmArrayList AL = new FrmArrayList();
        FrmLinqXml Xml = new FrmLinqXml();
        FrmArbolBB T2 = new FrmArbolBB();
        FrmArbol1 T1 = new FrmArbol1();
        FrmDijkstra1 G1 = new FrmDijkstra1();
        FrmGrafo G2 = new FrmGrafo();
        FrmListaCricDobl L3 = new FrmListaCricDobl();
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
            L2.MdiParent = this;
            AL.MdiParent = this;
            Xml.MdiParent = this;
            T2.MdiParent = this;
            T1.MdiParent = this;
            G1.MdiParent = this;
            G2.MdiParent = this;
            L3.MdiParent = this;
            au.MdiParent = this;
        }

        private void conPilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Show();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Hide();
        }

        private void conHilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Show();
            B1.Hide();
            L1.Hide();
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Hide();
        }

        private void conSeñalizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Show();
            L1.Hide();
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Hide();
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
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Hide();
        }

        private void listaEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            L2.Show();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Hide();
        }

        private void arrayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            L2.Hide();
            AL.Show();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Hide();
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
            L2.Hide();
            AL.Hide();
            Xml.Show();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Hide();
        }

        private void Arbol2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Show();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Hide();
        }

        private void Arbol1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Show();
            G1.Hide();
            G2.Hide();
            L3.Hide();
        }

        private void grafoDijkstra1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Show();
            G2.Hide();
            L3.Hide();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Show();
            L3.Hide();
        }

        private void listasCircularesYDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Hide();
            C1.Hide();
            B1.Hide();
            L1.Hide();
            L2.Hide();
            AL.Hide();
            Xml.Hide();
            T2.Hide();
            T1.Hide();
            G1.Hide();
            G2.Hide();
            L3.Show();
        }
    }
}
