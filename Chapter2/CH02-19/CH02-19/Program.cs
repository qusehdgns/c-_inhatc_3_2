using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-19
            int x = 9, y = 3;
            Console.WriteLine(x + " & " + y + " = " + (x & y));
            Console.WriteLine(x + "   " + y + " = " + (x | y));
            Console.WriteLine(x + " ^ " + y + " = " + (x ^ y));
            Console.WriteLine("~10 = " + (~10));
        }
    }
}
