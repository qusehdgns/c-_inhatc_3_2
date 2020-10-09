using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class StringIndexer
    {
        public char this[string str, int index]
        {
            get
            {
                return str[index];
            }
        }

        public string this[string str, int index, int len]
        {
            get
            {
                return str.Substring(index, len);
            }
        }
    }

    class Color
    {
        private string[] color = new string[5];

        public string this[int index]
        {
            get
            {
                return color[index];
            }
            set
            {
                color[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Color c = new Color();
            c[0] = "White";
            c[1] = "Red";
            c[2] = "Yellow";
            c[3] = "Blue";
            c[4] = "Black";
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Color is " + c[i]);
            }

            string str = "Hello";
            StringIndexer s = new StringIndexer();
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("{0}[{1}] = {2}", str, i, s[str, i]);
            }
            Console.WriteLine("Substring of {0} is {1}", str, s[str, 2, 3]);
        }
    }
}
