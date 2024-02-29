
using System.Windows.Forms;
using System.Drawing;

namespace PowerPaint
{
    internal class PanelChangeSize
    {
        Panel resizepanel;
        Panel mainpanel;
        int PointSize = 10;
        int hit = 0;




        public PanelChangeSize(Panel resizepanel, Panel mainpanel) 
        {
            this.resizepanel = resizepanel;
            this.mainpanel = mainpanel;
        }

        // Изменение размера панельки, при нажатии на квадратик 
        public void Resize(int x, int y)
        {
            Size size = resizepanel.Size;
            if (hit == 0) 
            {
                if (x < size.Width && x > size.Width - PointSize && y < size.Height && y > size.Height - PointSize)
                {
                   hit = 1;
                }
                if (x < size.Width/2 && x > size.Width/2 - PointSize && y < size.Height && y > size.Height - PointSize)
                {
                    hit = 2;
                }
                if (x < size.Width && x > size.Width - PointSize && y < size.Height/2 && y > size.Height/2 - PointSize)
                {
                    hit = 3;
                }
            }


            switch(hit)
            {
                case 1:
                    resizepanel.Size = new Size(x + 2, y + 2);
                    mainpanel.Size = new Size(x - PointSize + 2, y - PointSize + 2);
                    break;

                case 2:
                    resizepanel.Height = y + 2;
                    mainpanel.Height = y - PointSize + 2;
                    break; 
                
                case 3:
                    resizepanel.Width = x + 2;
                    mainpanel.Width = x - PointSize + 2;
                    break;
            }
        } 
        // Отрисовка зон изменения размера
        public void draw(Graphics graphics)
        {
            Size size = resizepanel.Size;
            graphics.Clear(resizepanel.BackColor);
            graphics.FillRectangle(Brushes.Black, new Rectangle(size.Width - PointSize, size.Height/2 - PointSize, PointSize, PointSize));
            graphics.FillRectangle(Brushes.Black, new Rectangle(size.Width/2 - PointSize, size.Height - PointSize, PointSize, PointSize));
            graphics.FillRectangle(Brushes.Black, new Rectangle(size.Width - PointSize, size.Height - PointSize, PointSize, PointSize));

        } 

        public void hitiff()
        {
            hit = 0;
        }
    }
}
