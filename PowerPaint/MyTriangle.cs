using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPaint
{
    internal class MyTriangle : Figure
    {

        public MyTriangle(int x, int y, int width, int height) : base(x, y, width, height)
        {

        }

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Point p1 = new Point(x+width/2, y);
            Point p2 = new Point(x, y+height);
            Point p3 = new Point(x+width,y+height);
            g.FillPolygon(brush, new Point[] { p1, p2, p3 });
            if (selected)
            {
                select_draw(g);
            }
        }

        public override Figure Clone()
        {
            return new MyTriangle(x, y, width, height);
        }
    }
}
