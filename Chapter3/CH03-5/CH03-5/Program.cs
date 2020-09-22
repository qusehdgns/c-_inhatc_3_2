using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 3-5
            int n;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            if (n % 2 == 0)
                Console.WriteLine(n + " is an even number.");
            if (n % 2 != 0)
                Console.WriteLine(n + " is an odd number.");
        }
    }
}
