using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-14
            int n, rem;
            rem = 10 % 3;
            n = 10 - (10 / 3) * 3;
            Console.WriteLine("10 % 3 = " + rem);
            Console.WriteLine("10 - (10 / 3) * 3 = " + n);
        }
    }
}
