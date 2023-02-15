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
    public partial class Autores : Form
    {
        InfoEdu IE = new InfoEdu();
        public Autores()
        {
            InitializeComponent();
        }

        private void Autores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IE.Show();
        }
    }
}
