using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_12
{
    class StringApp { }

    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-12
            StringApp obj = new StringApp();
            string str = "Class name is ";
            Console.WriteLine(str + obj.ToString());

            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append(obj.ToString());
            Console.WriteLine(sb);
        }
    }
}
