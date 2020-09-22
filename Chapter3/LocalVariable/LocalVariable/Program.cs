using System;

namespace LocalVariable
{
    class Local
    {
        public static int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = (Local.x = 2) * 2;
            Console.WriteLine("static : " + Local.x);
            Console.WriteLine("local : " + x);
        }
    }
}
