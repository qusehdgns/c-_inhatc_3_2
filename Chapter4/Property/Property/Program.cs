using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        class Fraction
        {
            private int num1;
            private int num2;

            public int Num1
            {
                get
                {
                    return num1;
                }
                set
                {
                    num1 = value;
                }
            }

            public int Num2
            {
                get
                {
                    return num2;
                }
                set
                {
                    num2 = value;
                }
            }

            public override string ToString()
            {
                return (num1 + "/" + num2);
            }
        }
        static void Main(string[] args)
        {
            Fraction f = new Fraction();
            f.Num1 = 1;
            int i = f.Num1 + 1;
            f.Num2 = i;
            Console.WriteLine(f.ToString());    
        }
    }
}
