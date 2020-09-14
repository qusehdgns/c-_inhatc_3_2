using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-17
            int x = 3, y = 5, z = 7;
            bool b;
            b = x < y && y < z;
            Console.WriteLine("Result = " + b);
            b = x == y | x < y && y > z;
            Console.WriteLine("Result = " + b);
        }
    }
}
