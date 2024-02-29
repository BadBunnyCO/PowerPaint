
using System.Collections.Generic;


namespace PowerPaint
{
    internal class ObjectList
    {
        public string backpic { get; set; }

        public int count { get; set; }
        public List<Figure> list { get; set; }

        public ObjectList() 
        {  
            this.list = new List<Figure>();
        }
    }
}
