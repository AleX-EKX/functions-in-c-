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
    public partial class Form7 : Form
    {
        int b = 0;
        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
            {
                label2.Text = "Правильно";
                b = b + 1;
            }
            else label2.Text = "Неправильно";
            // прячем кнопку что бы исключить повторный ввод
            // (угадывание ответа)
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label4.Text = "Правильно";
                b = b + 1;
            }
            else label4.Text = "Неправильно";
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true &&
 checkBox3.Checked == true &&
 checkBox2.Checked == false)
            {
                label6.Text = "Правильно";
                b = b + 1;
            }
            else label6.Text = "Неправильно";
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "Набрано баллов= " + Convert.ToString(b); ;
            if (b == 10) label8.Text = "Оценка 5 (отлично)";
            if (b == 9 || b == 8 || b == 7) label8.Text = "Оценка 4(хорошо)";
            if (b == 6 || b == 5) label8.Text = "Оценка 3(удовлетворительно)";
            if (b == 4 || b == 3) label8.Text = "Оценка 2(плохо)";
            if (b == 2 || b == 1) label8.Text = "Оценка 1(все ужасно)";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false &&
checkBox5.Checked == false &&
checkBox6.Checked == true)
            {
                label11.Text = "Правильно";
                b = b + 1;
            }
            else label11.Text = "Кого ты пытаешься обмануть";
            button3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true &&
checkBox8.Checked == true &&
checkBox9.Checked == true && checkBox10.Checked == false)
            {
                label18.Text = "Ой МОЛОДЕЦ 👍";
                b = b + 1;
            }
            else label18.Text = "Ты дурак?";
            button3.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label17.Text = "Харош,сам без понятия как это считать,да и нахрен это считать, иди лучше покури";
                b = b + 1;
            }
           

            else if (radioButton8.Checked == true)
            {
                label17.Text = "Респект, пошевелил мозгами";
                b = b + 1;
            }
            else label17.Text = "Ты гонишь чтоли? элементарный пример";
            button2.Visible = false;
        }
    }
}
