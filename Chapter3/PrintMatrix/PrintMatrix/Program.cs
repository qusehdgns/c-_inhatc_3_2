using System;

namespace PrintMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] iArr = { { 1, 2, 3, 10 },
                            { 4, 5, 6, 20 },
                            { 7, 8, 9, 30 }};

            Console.WriteLine(iArr.GetLength(0));
            Console.WriteLine(iArr.GetLength(1));

            for(int i = 0; i < iArr.GetLength(0); i++)
            {
                for(int j = 0; j < iArr.GetLength(1); j++)
                {
                    Console.Write("iArr[" + i + ", " + j + "] = " + iArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
