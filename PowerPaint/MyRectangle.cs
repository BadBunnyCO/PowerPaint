﻿using System.Drawing;


namespace PowerPaint
{
    internal class MyRectangle : Figure
    {
        public MyRectangle(int x, int y, int width, int height) : base(x, y, width, height)
        {

        }

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, x, y, width, height);
            if (selected)
            {
                select_draw(g);
            }
        }

        public override Figure Clone()
        {
            return new MyRectangle(x, y, width, height);
        }


    }
}
