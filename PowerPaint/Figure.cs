using System;
using System.Drawing;


namespace PowerPaint
{
    [Serializable]
    internal abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool selected { get; set; }
        public Color color { get; set; }


        public Figure(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
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
            /*if (x > this.x && y > this.y) {
                if (x - this.x > 5)
                {
                    this.width = x - this.x;
                }
                if (y - this.y > 5)
                {
                    this.height = y - this.y;
                }
            }*/
            if (x > this.x)
            {
                this.width = x - this.x;
            }
            else
            {
                this.width = this.x + this.width - x;
                this.x = x;
            }

            if (y > this.y)
            {
                this.height = y - this.y;
            }
            else
            {
                this.height = this.y + this.height - y;
                this.y = y;
            }
        }

        public void Move(int x, int y, int a = 0, int b =0)
        {
            this.x = x+a;
            this.y = y+b;
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
