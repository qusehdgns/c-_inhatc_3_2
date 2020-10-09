using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCall
{
    delegate void One();
    delegate void Two(int i);
    class AAA
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA");
        }

        public void Now()
        {
            Console.WriteLine("Time : " + DateTime.Now.ToString());
        }

        public static void Today()
        {
            Console.WriteLine("Date : " + DateTime.Today.ToString());
        }

        public void MethodB(int i)
        {
            Console.WriteLine("MethodB, i = " + i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AAA a = new AAA();

            One one = new One(a.MethodA);
            one += new One(a.Now);
            one += new One(AAA.Today);
            Two two = new Two(a.MethodB);

            one();

            two(10);
        }
    }
}
