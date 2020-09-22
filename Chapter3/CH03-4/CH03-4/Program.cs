using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CH03_4
{
    class Program
    {
        static int x;
        static void Main(string[] args)
        {
            // 예제 3-4
            int x = (Program.x = 2) * 2;
            Console.WriteLine("static x = " + Program.x);
            Console.WriteLine("local x = " + x);
        }
    }
}
