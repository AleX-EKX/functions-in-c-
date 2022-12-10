using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15pr
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void рис1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Ris1.jpg");
        }
    }
}
