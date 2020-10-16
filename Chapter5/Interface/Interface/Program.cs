using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IRect
    {
        void Area(int width, int height);
    }

    interface ITri
    {
        void Area(int width, int height);
    }

    class Shape : IRect, ITri
    {
        void IRect.Area(int width, int height)
        {
            Console.WriteLine("Rect = " + width * height);
        }

        void ITri.Area(int width, int height)
        {
            Console.WriteLine("Tri = " + width * height / 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            ((IRect)s).Area(20, 20);
            ((ITri)s).Area(20, 20);

            IRect r = s;
            r.Area(20, 20);

            ITri t = s;
            t.Area(20, 20);
        }
    }
}
