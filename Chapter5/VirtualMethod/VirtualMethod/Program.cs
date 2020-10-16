using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class AAA
    {
        virtual public void methodA()
        {
            Console.WriteLine("AAA methodA()");
        }
        virtual public void methodB()
        {
            Console.WriteLine("AAA methodB()");
        }
        public void methodC()
        {
            Console.WriteLine("AAA methodC()");
        }
    }

    class BBB : AAA
    {
        new public void methodA()
        {
            Console.WriteLine("BBB methodA()");
        }
        override public void methodB()
        {
            Console.WriteLine("BBB methodB()");
        }
        new public void methodC()
        {
            Console.WriteLine("BBB methodC()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AAA s = new BBB();
            s.methodA();
            s.methodB();
            s.methodC();
        }
    }
}
