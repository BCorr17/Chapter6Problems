using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet.cs
{
    class Program
    {
        public static void InchesToFeet(int inches)
        {
            int feet, inch;

            feet = inches / 12;
            inch = inches % 12;

            Console.WriteLine("This equals {0} feet and {1} Inches", feet, inch);
        }

        static void Main(string[] args)
        {
            int inches = 67;
            InchesToFeet(inches);
        }
    }
}
