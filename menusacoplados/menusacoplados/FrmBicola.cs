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

        private void Form4_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top= 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
