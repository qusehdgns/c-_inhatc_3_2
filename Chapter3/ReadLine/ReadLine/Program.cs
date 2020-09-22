using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int iTime, iHour, iMin, iSec;
            Console.Write("시간 입력 ");    // 3665 -> 1시간 1분 5초

            iTime = Int32.Parse(Console.ReadLine());
            iHour = iTime / 10000;
            iMin = iTime / 100 % 100;
            iSec = iTime % 100;

            Console.WriteLine(iHour + " : " + iMin + " : " + iSec);
        }
    }
}
