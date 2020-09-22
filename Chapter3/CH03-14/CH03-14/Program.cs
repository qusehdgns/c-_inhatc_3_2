using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_14
{
    class Program
    {   // h(n) = 1 + 1 / 2 + 1 / 3 + ... + 1 / n
        static void Main(string[] args)
        {
            // 예제 3-14
            int i, n;
            double h = 0.0;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            i = 1;
            do
            {
                h = h + 1 / (double)i;
                i++;
            } while (i <= n);
            Console.WriteLine("n = " + n + ", h = " + h);
        }
    }
}
