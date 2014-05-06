using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers2.cs
{
    class Program
    {
        public static int products(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            int q = 30, t = 39;
            int result = products(q, t);
            Console.WriteLine(result);
        }
    }
}
