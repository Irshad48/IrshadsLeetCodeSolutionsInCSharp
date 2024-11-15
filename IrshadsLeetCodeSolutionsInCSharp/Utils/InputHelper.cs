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
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        public static int ReadInt()
        {
            Console.WriteLine("Enter an integer:");
            return int.Parse(Console.ReadLine());
        }
    }
}
