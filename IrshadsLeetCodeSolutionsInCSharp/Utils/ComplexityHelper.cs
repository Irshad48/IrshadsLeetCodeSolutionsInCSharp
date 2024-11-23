using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrshadsLeetCodeSolutionsInCSharp.Utils
{
    internal static class ComplexityHelper
    {
        // Time complexity 
        public static string GetTimeComplexityBigON() => "Time Complexity: O(n)";
        public static string GetTimeComplexityBigO1() => "Time Complexity: O(1)";
        public static string GetTimeComplexityBigON2() => "Time Complexity: O(n^2)";
        public static string GetTimeComplexityBigOLogN() => "Time Complexity: O(log n)";
        public static string GetTimeComplexityBigONLogN() => "Time Complexity: O(n log n)";
        // Space complexity
        public static string GetSpaceComplexityBigON() => "Space Complexity: O(n)";
        public static string GetSpaceComplexityBigO1() => "Space Complexity: O(1)";
        public static string GetSpaceComplexityBigON2() => "Space Complexity: O(n^2)";
        public static string GetSpaceComplexityBigOLogN() => "Space Complexity: O(log n)";
        public static string GetSpaceComplexityBigONLogN() => "Space Complexity: O(n log n)";
    }
}
