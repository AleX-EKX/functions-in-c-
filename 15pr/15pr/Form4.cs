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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string a = dateTimePicker1.Value.ToLongDateString();
            textBox1.Text = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // устанавливаем новую дату
            monthCalendar1.TodayDate = new DateTime(2016, 09, 1);
            // убираем текущую дату снизу календаря
            monthCalendar1.ShowToday = false;
            // выделяем синим новую дату
            monthCalendar1.SelectionStart = new DateTime(2016, 09, 1);
            monthCalendar1.SelectionEnd = new DateTime(2016, 09, 1);
            //показываем дней недели и номер недели
            monthCalendar1.ShowWeekNumbers = true;
        }
    }
}
