using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    public class Circle
    {
        private int x;
        private int y;
        private int diameter;
        private int windowHeight;

        public Circle(int windowHeight, int diameter = 50)
        {
            this.diameter = diameter;
            this.windowHeight = windowHeight;
        }

        public int X
        {
            set
            {
                x = value;
            }
            
            get { return x; }
        }

        public int Y
        {
            set
            {
                y = windowHeight - value;
            }

            get { return y; }
        }

        public void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color.Black),
                x - diameter / 2,
                y - diameter / 2,
                this.diameter,
                this.diameter);
        }
    }
}
