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

        private void FrmArbol1_Load(object sender, EventArgs e)
        {

        }

        private void FrmArbol1_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
    }
}
