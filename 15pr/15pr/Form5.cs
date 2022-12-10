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
    public partial class Form5 : Form
    {
        float[] a = new float[1000];
        int n;
        Random rand = new Random();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            textBox2.Clear();
            for (int i = 0; i < n; i++)
            {
                // создаем случайное число от 1 до 99 (дробного
                // типа но без дробной части)
                float temp = rand.Next(1, 99);
                // добавляем дробную часть
                a[i] = temp / 10;
                textBox2.Text = textBox2.Text +
                Convert.ToString(a[i]) + "\r\n";
            };
        }
    }
}
