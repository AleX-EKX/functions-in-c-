using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace avtorization
{
    public partial class avtoriz : Form
    {
        public avtoriz()
        {
            InitializeComponent();
            animateComponent1.ShowForm(1000);
            LoginField.Text = "Введите логин";
            PassField.Text = "пароль";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * from `users` where `login`=@login and `pass`= @pass", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            db.conectionOpen();
            adapter.SelectCommand = command;
            adapter.Fill(table);//данные трансформируем внутрь обекта табл
            if (table.Rows.Count > 0)// если записей больше 0, то будет авторизован
            {
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("неправильный логин или пароль");
            }
            db.connectionClosed();
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if(LoginField.Text == "Введите логин")
                LoginField.Text = "";
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
                LoginField.Text = "Введите логин";
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "пароль")
                PassField.Text = "";
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            PassField.Text = "пароль";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration avt = new registration();
            avt.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            animateComponent1.CloseForm(2000);
        }
    }
}
