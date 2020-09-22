using System;

namespace OverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int iMax = int.MaxValue;

            try
            {
                i = iMax + 1;
                Console.WriteLine(i);

                unchecked
                {
                    i = iMax + 1;
                    Console.WriteLine(i);
                }

                checked
                {
                    i = iMax + 1;
                    Console.WriteLine(i);
                }
            }
            catch(OverflowException e)
            {
                Console.WriteLine("예외 발생" + e);
            }
        }
    }
}
