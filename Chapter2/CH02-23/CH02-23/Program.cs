using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예제 2-23
            int x, y = 2;
            x = 10; x += y; Console.Write("1. x = " + x + ",");
            x = 10; x -= y; Console.Write("\t2. x = " + x + ",");
            x = 10; x *= y; Console.Write("\t3. x = " + x + ",");
            x = 10; x /= y; Console.Write("\t4. x = " + x + ",");
            x = 10; x %= y; Console.WriteLine("\t5. x = " + x);
            x = 10; x &= y; Console.Write("6. x = " + x + ",");
            x = 10; x = y; Console.Write("\t7. x = " + x + ",");
            x = 10; x ^= y; Console.Write("\t8. x = " + x + ",");
            x = 10; x <<= y; Console.Write("\t9. x = " + x + ",");
            x = 10; x >>= y; Console.WriteLine("\t10. x = " + x);
        }
    }
}
