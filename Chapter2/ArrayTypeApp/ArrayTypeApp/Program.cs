using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] i2arr = new int[2][];
            i2arr[0] = new int[3];
            i2arr[1] = new int[3];
            Console.WriteLine(i2arr.Length);
            Console.WriteLine(i2arr[0].Length);
            for (int i = 0; i < i2arr.Length; i++)
            {
                for (int j = 0; j < i2arr[i].Length; j++)
                {
                    Console.Write("{0} ", i2arr[i][j]);
                }
                Console.WriteLine();
            }

            int[,] iarr = new int[2, 3];
            iarr[0, 0] = 1;
            iarr[0, 1] = 2;
            iarr[0, 2] = 3;
            iarr[1, 0] = 4;
            iarr[1, 1] = 5;
            iarr[1, 2] = 6;

            Console.WriteLine(iarr.GetLength(0));
            Console.WriteLine(iarr.GetLength(1));

            for(int i = 0; i < iarr.GetLength(0); i++)
            {
                for(int j = 0; j < iarr.GetLength(1); j++)
                {
                    Console.Write("{0} ", iarr[i, j]);
                }
                Console.WriteLine();
            }


            /*
            // 배열
            int[] ia = new int[3];
            ia[0] = 10;
            ia[1] = 100;
            ia[2] = 30;

            int[] ib = { 1, 2, 3, 4 };

            ib = ia;

            for(int i = 0; i < ib.Length; i++)
            {
                Console.WriteLine(ib[i]);
            }
            */
        }
    }
}
