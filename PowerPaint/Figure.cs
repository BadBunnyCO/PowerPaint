using System;
using System.Drawing;
using System.Windows.Forms;


namespace PowerPaint
{
    [Serializable]
    internal abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public bool selected { get; set; }
        public Color color { get; set; }


        public Figure(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            p1 = new Point(x, y);
            p2 = new Point(x+width, y+height);
            this.color = Color.Gold;
        }

        public abstract void draw(Graphics g);
        
        public void ChangeColor(Color color)
        {
            this.color = color;
        }

        public void select_draw(Graphics g)
        {
            g.FillRectangle(Brushes.Black, x-5, y-5, 5, 5);
            g.FillRectangle(Brushes.Black, x-5, y+height, 5, 5);
            g.FillRectangle(Brushes.Black, x+width, y-5, 5, 5);
            g.FillRectangle(Brushes.Black, x+width, y+height, 5, 5);

        }

        public void Resize(int w, int h)
        {
            if(this.width - w > 5)
            {
                this.width = w;
            }

            if (this.height - h > 5)
            {
                this.height = h;
            }
        }

        public void ResizeCor(int x, int y)
        {

            if(x > p1.X)
            {
                this.x = p1.X;
                width = x - p1.X;
            }
            else
            {
                this.x = x;
                width = p1.X - x;
            }

            if(y > p1.Y)
            {
                this.y = p1.Y;
                height = y - p1.Y;
            }
            else
            {
                this.y = y;
                height = p1.Y - y;
            }

            p2 = new Point(p1.X - (p1.X -x), p1.Y - (p1.Y - y));
        }

        public void Move(int x, int y, int a = 0, int b =0)
        {
            int xt = this.x;
            int yt = this.y;

            this.x = x+a;
            this.y = y+b;

            int x1 = p1.X+(this.x - xt);
            int y1 = p1.Y+(this.y -yt);
            int x2 = p2.X+ (this.x - xt);
            int y2 = p2.Y+ (this.y - yt);
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
        }

        public bool Selected(int x, int y)
        {
            if(x > this.x && y > this.y && x < width+this.x && y < height + this.y)
            {
                selected = true;
            }
            else
            {
                selected = false;
            }
            return selected;
        }

        public abstract Figure Clone();
    }
}
