using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 3-17
            int n, s, i;
            Console.Write("Enter a number = ");
            for(; ; )
            {
                n = Console.Read() - '0';
                if (n == 0) break;
                else if (n < 0) continue;
                for (s = 0, i = 1; i <= n; ++i)
                    s += i;
                Console.WriteLine("n = " + n + ", sum = " + s);
            }
            Console.WriteLine("End of Main");
        }
    }
}
