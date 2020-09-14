using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_27
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-27
            int big = 1234567890;
            float approx;
            approx = (float)big;
            Console.WriteLine("difference = " + (big - (int)approx));
        }
    }
}
