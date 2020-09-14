using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-24
            int i = 0xffff;
            short s;
            s = (short)i;
            Console.WriteLine("i = " + i);
            Console.WriteLine("s = " + s);
        }
    }
}
