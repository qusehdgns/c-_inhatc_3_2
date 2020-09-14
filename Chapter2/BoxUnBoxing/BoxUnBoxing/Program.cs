using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxUnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int foo = 526;
            object bar = foo;
            Console.WriteLine(bar);

            try
            {
                double d = (int)bar;
                Console.WriteLine(d);
            }
            catch(Exception e)
            {
                Console.WriteLine(e + "Error");
            }
        }
    }
}
