using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int x0 = ClientSize.Width / 2;
            int y0 = ClientSize.Height / 2;
            int r = 150;

            // Внутренние круги
            //double a = 3.0;
            //for (int i = 0; i < 6; i++)
            //{
            //    double angle = a * Math.PI / 6.0;
                Circle circle = new Circle(ClientSize.Height);
                //circle.X = (int) (r * Math.Sin(angle));
                circle.X = 0;
                circle.Y = 0;
                Graphics gr = CreateGraphics();
                circle.Draw(gr);
            //    a += 2.0;
            //}

            Console.WriteLine(Math.PI);

            int d = 50;
            int x = x0 - d / 2;
            int y = y0 - d / 2;
        }
    }
}
