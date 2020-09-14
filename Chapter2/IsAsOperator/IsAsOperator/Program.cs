using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IsOperator(10);
            IsOperator("ABC");

            AsOperator(10);
            AsOperator("ABC");
        }

        private static void AsOperator(object v)
        {
            Console.WriteLine(v + " as String == null : " + (v as string == null));
        }

        private static void IsOperator(object v)
        {
            Console.WriteLine(v + " is int : " + (v is int));
            Console.WriteLine(v + " is string : " + (v is string));
        }
    }
}
