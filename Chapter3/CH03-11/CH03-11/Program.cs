using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 3-11
            int i, n;
            double h = 0.0;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            for (i = 1; i <= n; ++i)
                h = h + 1 / (double)i;
            Console.WriteLine("n = {0}, h = {1}", n, h);
        }
    }
}
