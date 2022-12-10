using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace pr
{

    
    public partial class AddForm : Form
    {
        DB db = new DB();

        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.openConnection();
            var supplier = textBox_supplier.Text;
            var type = textBox_typesup.Text;
            int inn;
            var reyting = textBox_reyting.Text;

            var datar = textBox_datar.Text;
            if (int.TryParse(textBox_inn.Text, out inn))
            {
                var addQuery = $"insert into supplier (name_supplier, type_supplier, inn, reyting, data_raboti) values ('{ supplier}', '{type}', '{inn}', '{ reyting}','{datar}')";

                MySqlCommand command = new MySqlCommand(addQuery, db.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!!", "Усппех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой форматі", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            db.closeConnection();
        }
    }
}
