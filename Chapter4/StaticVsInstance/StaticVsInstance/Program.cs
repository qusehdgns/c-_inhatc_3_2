using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsInstance
{
    class SI
    {
        public int inst;
        public static int stat = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SI.stat);
            SI si = new SI();
            si.inst = 10;
            SI.stat = 20;
            Console.WriteLine("instance = {0}, static = {1}", si.inst, SI.stat);
        }
    }
}
