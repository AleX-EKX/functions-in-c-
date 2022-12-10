using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtorization
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            animateComponent1.ShowForm(1000);
            loginfield.Text = "Введите логин";
            passfield.Text = "пароль";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // проверка на ввод всех полей
            if (loginfield.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passfield.Text == "пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (Checkuser())
                return;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`,`pass`) VALUES (@login, @pass)", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginfield.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value=passfield.Text;
            db.conectionOpen();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь успешно добавлен");
                this.Hide();
                avtoriz avt = new avtoriz();
                avt.Show();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
            db.connectionClosed();
        }

        public Boolean Checkuser()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * from `users` where `login`= @login", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginfield.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);//данные трансформируем внутрь обекта табл
            if (table.Rows.Count > 0)// если записей больше 0, то neбудет авторизован
            {
                MessageBox.Show("Данный логин уже существует");
                return true;
            }
            else
                return false;
        }

        private void loginfield_Enter(object sender, EventArgs e)
        {
            if(loginfield.Text=="Введите логин")
            {
                loginfield.Text = "";
            }
        }

        private void passfield_Enter(object sender, EventArgs e)
        {
            if (passfield.Text == "пароль")
            {
                passfield.Text = "";
            }
        }

        private void loginfield_Leave(object sender, EventArgs e)
        {
            if (loginfield.Text == "")
            {
                loginfield.Text = "Введите логин";
            }
        }

        private void passfield_Leave(object sender, EventArgs e)
        {
            if (passfield.Text == "")
            {
                passfield.Text = "пароль";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            avtoriz avt = new avtoriz();
            avt.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            animateComponent1.CloseForm(2000);
        }
    }
}
