using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterArray
{
    class Program
    {
        static void Main(string[] args)
        {
            PArray(123, "hello", true, 'A');
            PArray("AAAA", true, 'A', 123);
            PArray("BBBB", true);
        }

        private static void PArray(params object[] obj)
        {
            for(int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine(obj[i]);
            }
        }
    }
}
