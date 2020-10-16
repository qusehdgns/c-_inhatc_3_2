using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class C
    {
        virtual public void Print()
        {
            Console.WriteLine("C 언어");
        }
    }

    class Java : C
    {
        override public void Print()
        {
            Console.WriteLine("Java 언어");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C lang = new C();
            lang.Print();
        }
    }
}
