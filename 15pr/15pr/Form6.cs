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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
            " Вариантов нет, всего одна кнопка :( ",
            "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            textBox1.Text = "Вы нажали ОК";
            // Ставим нашу форму поверх всех окон
            this.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
 "Выберите один из вариантов", "Сообщение",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1,
MessageBoxOptions.DefaultDesktopOnly);
            // Проверяем какая кнопка нажата ...
            if (result == DialogResult.Yes)
                textBox1.Text = "Вы нажали ДА";
            else
                textBox1.Text = "Вы нажали НЕТ";
            // Ставим нашу форму по верх всех окон
            this.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show(
 "Выберите один из вариантов",
"Сообщение",
 MessageBoxButtons.YesNoCancel,
MessageBoxIcon.Error,
MessageBoxDefaultButton.Button1,
MessageBoxOptions.DefaultDesktopOnly);
            if (DialogResult == DialogResult.Yes)
                textBox1.Text = "Вы нажали ДА";
            if (DialogResult == DialogResult.No)
                textBox1.Text = "Вы нажали НЕТ";
            if (DialogResult == DialogResult.Cancel)
                textBox1.Text = "Вы нажали ОТМЕНА";
            this.TopMost = true;
        }
    }
}
