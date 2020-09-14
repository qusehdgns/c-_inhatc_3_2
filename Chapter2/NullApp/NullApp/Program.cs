using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 10;

            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);

            if (num1.HasValue)
            {
                Console.WriteLine("num1 = " + num1.Value);
            } else
            {
                Console.WriteLine("num1은 값이 없네요.");
            }

            if (num2.HasValue)
            {
                Console.WriteLine("num2 = " + num2.Value);
            }
            else
            {
                Console.WriteLine("num2은 값이 없네요.");
            }
        }
    }
}
