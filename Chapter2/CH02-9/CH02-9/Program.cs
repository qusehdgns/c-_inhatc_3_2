using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_9
{
    enum Color {Red, Green, Blue};
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-9
            Color c = Color.Red;
            c++;
            int i = (int)c;
            Console.WriteLine("Cardinality of " + c + " = " + i);
        }
    }
}
