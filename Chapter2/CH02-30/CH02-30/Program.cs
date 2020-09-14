using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_30
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-30
            double? num1 = null;    // 오류로 인한 실행 안함 수정
            double? num2 = 10.0;

            if (num1.HasValue)
                Console.WriteLine("num1 = " + num1.Value);
            else
                Console.WriteLine("num1 does not have value.");
            if (num2.HasValue)
                Console.WriteLine("num2 = " + num2.Value);
            else
                Console.WriteLine("num2 does not have value.");
        }
    }
}
