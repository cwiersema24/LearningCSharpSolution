using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCSharp
{
    public class Thingy
    {
        public string FormatName(string first, string last)
        {
            return $"{last}, {first}";
        }

        public string FormatName(string first, string last, string mi)
        {
            return FormatName(first, last) + $" {mi}.";
        }
        /// <summary>
        /// Allows you to add two integers
        /// </summary>
        /// <param name="a">The first number (default of 5)</param>
        /// <param name="b">The second number (default of 10)</param>
        /// <returns> a and b all added up and stuff</returns>
        public int Add(int a=5, int b = 10)
        {
            return a + b;
        }
        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }

}
