using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;

namespace pr
{
    public partial class Form1 : Form
    {        //подключаем к бд
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = магазин.mdb";
        public OleDbConnection myconnection;
        public Form1()
        {
            InitializeComponent();
            //связь к бд
            myconnection = new OleDbConnection(connectString);
            myconnection.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазинDataSet.товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.магазинDataSet.товары);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            //закрытие соединения
            myconnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {            //удаление
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "DELETE FROM Товары WHERE [Код товара] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myconnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о товаре удалены");
            this.товарыTableAdapter.Fill(this.магазинDataSet.товары);
        }
        private void button2_Click(object sender, EventArgs e)
        {            //редактирование
            int kod = Convert.ToInt32(textBox2.Text);

            int kod_o = Convert.ToInt32(otdel.Text);
            string name_t = nametov.Text;
            int cenaa = Convert.ToInt32(cena.Text);
            int kod_p = Convert.ToInt32(prodavec.Text);

            string query = "UPDATE Товары SET Цена = '" + cenaa + "', [наименование товара] = '"+ name_t + "',[№ отдела] = '" + kod_o + "',[код продавца] = '" + kod_p + "' WHERE [Код товара] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myconnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о товаре обновлены");
            this.товарыTableAdapter.Fill(this.магазинDataSet.товары);//обновление
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //родительская форма
            f2.Owner = this;
            f2.Show();
        }
        private void поЦенеToolStripMenuItem_Click(object sender, EventArgs e)
        {            // сортировка
            myconnection = new OleDbConnection(connectString);
            myconnection.Open();
            string query = "SELECT * FROM Товары ORDER BY цена ASC";
                 OleDbDataAdapter command = new OleDbDataAdapter(query, myconnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myconnection.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {            //поиск
            myconnection = new OleDbConnection(connectString);
            myconnection.Open();
            string pocene = textBox_search.Text;
            string query = "SELECT * FROM Товары WHERE [наименование товара] LIKE '%" + pocene + "%' or цена LIKE '%" + pocene + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myconnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myconnection.Close();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {            //обновление
            this.товарыTableAdapter.Fill(this.магазинDataSet.товары);
        }
        private void поНазваниюТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {// сортировка
            myconnection = new OleDbConnection(connectString);
            myconnection.Open();
            string query = "SELECT * FROM товары ORDER BY [наименование товара]";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myconnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myconnection.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {//экспорт
            excel.Application exApp = new excel.Application();
            exApp.Workbooks.Add();
            excel.Worksheet wish = (excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i=0;i<=dataGridView1.RowCount-2;i++)
            {
                for (j=0;j<=dataGridView1.ColumnCount-1;j++)
                {
                    wish.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            //родительская форма
            f3.Owner = this;
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            //родительская форма
            f4.Owner = this;
            f4.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                otdel.Text = row.Cells[1].Value.ToString();
                nametov.Text = row.Cells[2].Value.ToString();
                cena.Text = row.Cells[3].Value.ToString();
                prodavec.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            otdel.Text = "";
            nametov.Text = "";
            cena.Text = "";
            prodavec.Text = "";
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string cenaa = textBox3.Text;
             myconnection = new OleDbConnection(connectString);
             myconnection.Open();
             string avtoriz = "SELECT * FROM товары where [наименование товара] = '" + login + "' AND цена = " + cenaa;
             OleDbDataAdapter command = new OleDbDataAdapter(avtoriz, myconnection);
             DataTable dt = new DataTable();
            command.Fill(dt);
            // Проверяем, что количество строк из БД больше нуля
            if (dt.Rows.Count > 0)
            {
                // Нужный Вам ID
                string ID = dt.Rows[0][0].ToString();
                this.Hide();
                Form4 ss = new Form4();
                ss.Show();
            }
            else
            {                
                MessageBox.Show("Неправильно введённые имя или пароль");
            }
            myconnection.Close();
                    }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите логин")//если текст равен внутри формы введите имя, то будет очистка от текста
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")//если поле пустое, то напишем введите имя
                    textBox1.Text = "Введите логин";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
