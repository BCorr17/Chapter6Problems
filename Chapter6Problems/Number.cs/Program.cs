using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Number.cs
{
    class Program
    {
        public static void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void difference(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main()
        {
            int q = 30, t = 39;
            sum(q, t);
            difference(q, t);
        }
    }
}
