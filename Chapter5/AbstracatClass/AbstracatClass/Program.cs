using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracatClass
{
    abstract class AAA
    {
        public abstract void MethodA();
        public void MethodB()
        {
            Console.WriteLine("MethodB()");
        }
    }

    class BBB : AAA
    {
        public override void MethodA()
        {
            Console.WriteLine("MethodA()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AAA b = new BBB();
            b.MethodA();
            b.MethodB();
        }
    }
}
