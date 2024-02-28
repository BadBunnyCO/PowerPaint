using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPaint
{
    internal class MyText : Figure
    {
        public MyText(int x, int y, int width, int height) : base(x, y, width, height)
        {

        }

        public override void draw(Graphics g)
        {
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(color);
            RectangleF drawRect = new RectangleF(x, y, width, height);
            StringFormat drawFormat = new StringFormat();
            g.DrawString("Test", drawFont, drawBrush, drawRect, drawFormat);
            if (selected)
            {
                g.DrawRectangle(new Pen(Color.Black), x, y, width, height);
                select_draw(g);
            }
        }

        public override Figure Clone()
        {
            return new MyText(x, y, width, height);
        }

    }
}
