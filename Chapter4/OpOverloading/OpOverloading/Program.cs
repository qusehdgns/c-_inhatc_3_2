using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOverloading
{
    class Complex
    {
        private double real;
        private double image;

        public Complex(double rVal, double iVal)
        {
            real = rVal;
            image = iVal;
        }

        public static Complex operator + (Complex x1, Complex x2)
        {
            Complex x = new Complex(0, 0);
            x.real = x.real + x2.real;
            x.image = x1.image + x2.image;
            return x;
        }

        public override string ToString()
        {
            return "(" + real + ", " + image + "i)";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c, c1, c2;
            c1 = new Complex(1, 2);
            c2 = new Complex(3, 4);
            c = c1 + c2;
            Console.WriteLine(c1 + " + " + c2 + " = " + c);
        }
    }
}
