using System;
using System.Diagnostics.CodeAnalysis;

namespace JumpSt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s, i;
            for(; ; )
            {
                Console.Write("숫자 입력 : ");
                n = int.Parse(Console.ReadLine());

                if(n == 0)
                {
                    break;
                }
                else if(n < 0)
                {
                    continue;
                }

                for(s = 0, i = 1; i <= n; i++)
                {
                    s = sum(s, i);
                }
                Console.WriteLine("n = {0}, sum = {1}", n, s);
            }
            Console.WriteLine("End of Main");
        }

        private static int sum(int s, int i)
        {
            return s + i;
        }
    }
}
