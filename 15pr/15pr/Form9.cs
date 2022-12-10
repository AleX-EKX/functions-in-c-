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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // линия
            g.DrawLine(new Pen(Color.Black, 3), 10, 10, 200, 10);
            g.DrawLine(new Pen(Color.Black, 3), 10, 10, 200, 10);
            // прямоугольник нижний левый угол длина и высота
            g.DrawRectangle(System.Drawing.Pens.Black, 10, 30, 190, 20);
            // закрашеный прямоугольник
            g.FillRectangle(System.Drawing.Brushes.Blue, 10, 60, 190, 20);
            // эллипс (окружность)
            g.DrawEllipse(new Pen(Color.Red, 3), 10, 100, 190, 30);
            // закрашенный элипс
            g.FillEllipse(System.Drawing.Brushes.Green, 10, 140, 190, 30);
            // дуга в прямоугольнике,
            //0 и 180 это градусы рисует по часовой стрелке
            g.DrawArc(new Pen(Color.Red, 3), 10, 180, 190, 30, 0, 180);
            // закрашенный сектор
            g.FillPie(System.Drawing.Brushes.Green, 10, 200, 190, 80, 0, 180);
            // устанавливаем шкифт, размер и стиль
            Font f = new System.Drawing.Font("Times New Roman", 12,
           System.Drawing.FontStyle.Bold);
            // устанавливаем цвет
            SolidBrush f1 = new SolidBrush(Color.Green);
            // выводим надписи
            g.DrawString("Линия ", f, f1, 210, 10);
            g.DrawString("Прямоугольник ", f, f1, 210, 50);
            g.DrawString("Эллипс ", f, f1, 210, 130);
            g.DrawString("Дуга ", f, f1, 210, 190);
            g.DrawString("Сектор ", f, f1, 210, 240);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
        }
    }
}
