using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 3-1
            short s;
            int i;
            float f;
            double d;
            s = 526;
            d = f = i = s;
            Console.WriteLine("s = " + s + " i = " + i);
            Console.WriteLine("f = " + f + " d = " + d);
        }
    }
}