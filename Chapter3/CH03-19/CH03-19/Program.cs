using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 3-19
            int i, max = int.MaxValue;
            try
            {
                Console.WriteLine("Start of try statement");
                i = max + i;    // default: don't check Overflow.
                Console.WriteLine("After default overflow");
                unchecked
                {
                    i = max + i; // don't check Overflow intensionally.
                }
                Console.WriteLine("After unchecked statement");
                checked
                {
                    i = max + i; // check Overflow
                }
                Console.WriteLine("After checked statement");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("caught an OverflowException");
            }
        }
    }
}
