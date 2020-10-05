using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fract
    {
        private int numerator;      // 분자
        private int denominator;    // 분모

        public Fract(int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }

        public void PrintFract()
        {
            Console.WriteLine(numerator + "/" + denominator);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fract f = new Fract(1, 2);
            f.PrintFract();
        }
    }
}
