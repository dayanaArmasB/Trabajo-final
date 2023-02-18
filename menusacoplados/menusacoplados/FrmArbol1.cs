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
    public partial class FrmArbol1 : Form
    {
        public FrmArbol1()
        {
            InitializeComponent();
        }
        List<TreeNode> marcados = new List<TreeNode>();
        private void FrmArbol1_Load(object sender, EventArgs e)
        {
            for (int n = 1; n <= 5; n++)
            {
                comboBox2.Items.Add("Elementos" + n);
            }
        }

        private void FrmArbol1_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnAgregaNodo_Click(object sender, EventArgs e)
        {
            TreeNode nodo = new TreeNode(textBox1.Text);
            treeView1.Nodes.Add(nodo);
        }

        private void btnAGregarsubnodo_Click(object sender, EventArgs e)
        {
            TreeNode nodo = new TreeNode(comboBox2.SelectedItem.ToString());
            treeView1.SelectedNode.Nodes.Add(nodo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            removerMarcados(treeView1.Nodes);

        }
        void removerMarcados(TreeNodeCollection nodos)
        {
            foreach (TreeNode nodo in nodos)
            {
                if (nodo.Checked)
                {
                    marcados.Add(nodo);
                }
                else
                {
                    removerMarcados(nodo.Nodes);
                }

            }
            foreach (TreeNode marcado in marcados)
            {
                nodos.Remove(marcado);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                TreeNode nodi = treeView1.Nodes[i];
                object[] row = new object[nodi.Nodes.Count];
                for (int j = 0; j < nodi.Nodes.Count; j++)
                {
                    row[j] = nodi.Nodes[j].Text;
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
