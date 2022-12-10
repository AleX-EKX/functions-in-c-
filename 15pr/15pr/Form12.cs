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
    public partial class Form12 : Form
    {
        int d = 1;
        public Form12()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //изменяем расстояние до края формы
            pictureBox1.Left = pictureBox1.Left + d;
            //если достигнут левый или правый край формы
            if (pictureBox1.Left >= 640 || pictureBox1.Left <= 0)
            {
                //в зависимости от того куда двигались,
                // меняем рисунок
                if (d > 0) pictureBox1.Image = Image.FromFile("Ris2.jpg");
                if (d < 0) pictureBox1.Image = Image.FromFile("Ris1.jpg");
                //изменяем направление движения
                d = -d;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (d >= 0) d = trackBar1.Value;
            if (d < 0) d = -trackBar1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
