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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // настраиваем фильтр при сохранении файла
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // вызываем метод открытия диалогового окна
            saveFileDialog1.ShowDialog();
            // в f будем хранить имя файла для сохранения массива
            string f = saveFileDialog1.FileName;
            // сохраняем содержимое textBox2.Text в файл
            System.IO.File.WriteAllText(f, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // настраиваем фильтр при открытии файла
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // вызываем метод открытия диалогового окна
            openFileDialog1.ShowDialog();
            // в f будем хранить имя файла из которого будем считывать массив
            string f = openFileDialog1.FileName;
            // переносим содержимое файла в textBox2.Text
            textBox2.Text = System.IO.File.ReadAllText(f);
            // что бы пользователь пощелкал мышкой :)
            MessageBox.Show(" Файл открыт ");
        }
    }
}
