using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class AAA
    {
        static int sa = 100;
        static int sb;

        static AAA()
        {
            sb = sa + 100;
        }

        public static void printA()
        {
            Console.WriteLine("sa = {0}, sb = {1}", sa, sb);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AAA.printA();
        }
    }
}
