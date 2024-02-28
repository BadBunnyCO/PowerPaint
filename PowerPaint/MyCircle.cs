using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPaint
{
    internal class MyCircle : Figure
    {
        public MyCircle(int x, int y, int width, int height) : base(x, y, width, height)
        {

        }

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, x, y, width, height);
            if (selected)
            {
                select_draw(g);
            }
        }

        public override Figure Clone()
        {
            return new MyCircle(x, y, width, height);
        }
    }
}
