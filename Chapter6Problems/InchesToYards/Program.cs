using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet.cs
{
    class Program
    {
        public static void InchesToYards(int inches)
        {
            int feet, inch, yard;

            feet = inches / 12;
            inch = inches % 12;
            yard = feet / 3;

            Console.WriteLine("This equals {0} yard  {1} feet and {2} Inches", yard, feet, inch);
        }

        static void Main(string[] args)
        {
            int inches = 67;
            InchesToYards(inches);
        }
    }
}
