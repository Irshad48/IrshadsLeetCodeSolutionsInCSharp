using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrshadsLeetCodeSolutionsInCSharp.Utils
{
    internal class InputHelper
    {
        public static int[] ReadIntArray()
        {
            Console.WriteLine("Enter integers separated by spaces:");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided. Returning an empty array.");
                return Array.Empty<int>(); 
            }
            return input.Split(' ').Select(int.Parse).ToArray();
        }

        public static int ReadInt()
        {
            Console.WriteLine("Enter an integer:");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }
            return int.Parse(input);
        }
    }
}
