using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-10
            int[] ia = new int[3];
            int[] ib = { 1, 2, 3 };
            // int[] ib = new int[] {1, 2, 3} 과 같은 의미
            int i;
            for (i = 0; i < ia.Length; i++)
                ia[i] = ib[i];
            for (i = 0; i < ia.Length; i++)
                Console.WriteLine(ia[i] + " ");
            Console.WriteLine();
        }
    }
}
