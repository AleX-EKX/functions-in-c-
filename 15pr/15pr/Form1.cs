using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _15pr
{
    public partial class Form1 : Form
    {
        int n, m, i, j;

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                dataGridView1.Rows.RemoveAt(cell.RowIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = dataGridView1.RowCount; // определяем число строк
            m = dataGridView1.ColumnCount; // определяем число столбцов
                                           //Создаём или перезаписываем существующий файл
            StreamWriter sw = File.CreateText("data.txt");
            //Записываем текст в поток файла
            sw.WriteLine(Convert.ToString(n));
            sw.WriteLine(Convert.ToString(m));
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    sw.WriteLine(Convert.ToString(dataGridView1[j, i].Value));
                }
            }
            //Закрываем файл
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Создаем файловую переменную для чтения данных
            StreamReader f = new StreamReader("data.txt");
            //читаем первые две строки из файла
            n = Convert.ToInt32(f.ReadLine());
            m = Convert.ToInt32(f.ReadLine());
            //перебираем строки
            for (i = 0; i < n - 1; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["ID"].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[1].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[2].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells["Tel"].Value = f.ReadLine();
            }
            //Закрываем файл
            f.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Добавляем строку с номером rowNumber
            int rowNumber = dataGridView1.Rows.Add();
            //Заполняем ячейки
            dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber;
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowNumber].Cells[2].Value = textBox2.Text;
            // можно по номеру столбца а можно по идентефикатору
            dataGridView1.Rows[rowNumber].Cells["Tel"].Value = textBox3.Text;
            //Стираем поля ввода для новой информации
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // загрузка формы
            //создаём и добавляем столбцы
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("Fa", "Фамилия");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Tel", "Телефон");
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
