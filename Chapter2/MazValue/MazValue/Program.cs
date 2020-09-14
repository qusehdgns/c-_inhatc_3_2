using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int res;

            a = 10;
            b = 20;
            a *= b + 2; // a = a * (b + 2)
            Console.WriteLine(a);

            Console.Write("세개의 정수를 입력하세요."); // 321
            a = Console.Read() - '0';
            b = Console.Read() - '0';
            c = Console.Read() - '0';

            res = (a > b) ? a : b;
            res = (res > c) ? res : c;

            Console.WriteLine("max : " + res);

        }
    }
}
