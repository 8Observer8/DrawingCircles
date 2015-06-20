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
            int r = 50;

            // Внутреннии круги
            double a = 3.0;
            for (int i = 0; i < 6; i++)
            {
                double angle = a * Math.PI / 6.0;
                Circle circle = new Circle(ClientSize.Width, ClientSize.Height, 40);
                circle.X = (int) (r * Math.Cos(angle));
                circle.Y = (int)(r * Math.Sin(angle));
                Graphics gr = CreateGraphics();
                circle.Draw(gr);
                a += 2.0;
            }

            // Внешнии круги
            a = 3.0;
            r = 150;
            for (int i = 0; i < 6; i++)
            {
                double angle = a * Math.PI / 6.0;
                Circle circle = new Circle(ClientSize.Width, ClientSize.Height, 40);
                circle.X = (int)(r * Math.Sin(angle));
                circle.Y = (int)(r * Math.Cos(angle));
                Graphics gr = CreateGraphics();
                circle.Draw(gr);
                a += 2.0;
            }
        }
    }
}
