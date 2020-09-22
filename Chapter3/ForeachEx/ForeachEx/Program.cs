using System;

namespace ForeachEx
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] color = { "red", "green", "blue" };
            int[] nums = { 1, 2, 3 };
            foreach(var item in color)
            {
                Console.WriteLine(item);
            }
        }
    }
}
