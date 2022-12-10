using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr
{
    public partial class Form2 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = магазин.mdb";
        public OleDbConnection myconnection;
        public Form2()
        {
            InitializeComponent();
            myconnection = new OleDbConnection(connectString);
            myconnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod_t = Convert.ToInt32(textBox1.Text);
            int kod_o = Convert.ToInt32(textBox2.Text);
            string name_t = textBox3.Text;
            int cena = Convert.ToInt32(textBox4.Text);
            int kod_p = Convert.ToInt32(textBox5.Text);
            string query = "INSERT INTO Товары  VALUES (" + kod_t + "," + kod_o + ",'" + name_t +"'," + cena + "," + kod_p + ")";
            OleDbCommand command = new OleDbCommand(query, myconnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
