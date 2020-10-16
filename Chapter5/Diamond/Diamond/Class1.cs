using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Rect
    {
        private int width;
        private int height;

        public Rect(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Area()
        {
            Console.WriteLine("Area = " + width * height);
        }
    }
}
