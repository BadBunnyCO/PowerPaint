using System.Drawing;

namespace PowerPaint
{
    internal class MyLine : Figure
    {

        public MyLine(int x, int y, int width, int height) : base(x, y, width, height)
        {

        }


        public override void draw(Graphics g)
        {
            Pen pen = new Pen(color, 5);
            //p2 = new Point(x + width, y + height);
            g.DrawLine(pen, p2, p1);
            if (selected)
            {
                select_draw(g);
            }
        }

            public override Figure Clone()
        {
            return new MyLine(x, y, width, height);
        }
    }

}
