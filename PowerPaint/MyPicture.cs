using System.Drawing;
using System.IO;

namespace PowerPaint
{
    
    internal class MyPicture : Figure
    {
        public string filename { get; set; }
        Bitmap picture;
        public MyPicture(int x, int y, int width, int height, string filename = "defualt.jpg") : base(x, y, width, height)
        {
            this.filename = filename;
            picture = new Bitmap(this.filename);
        }

        public void SetPicture(string filename)
        {
            if (File.Exists(filename))
            {
                this.filename = filename;
                picture = new Bitmap(filename);
            }
            else 
            {
                this.filename = "defualt.jpg";
                picture = new Bitmap(filename);
            }
            
        }

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.DrawImage(picture, x, y, width, height);
            if (selected)
            {
                select_draw(g);
            }
        }

        public override Figure Clone()
        {
            return new MyPicture(x,y,width,height,filename);
        }
    }
}
