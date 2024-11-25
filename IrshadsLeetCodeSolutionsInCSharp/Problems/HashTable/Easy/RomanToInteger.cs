using IrshadsLeetCodeSolutionsInCSharp.Problems.Arrays.Easy;
using IrshadsLeetCodeSolutionsInCSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrshadsLeetCodeSolutionsInCSharp.Problems.HashTable.Easy
{
    /*
    Problem statement
    
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    Symbol       Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000
    For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

    Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.
    Given a roman numeral, convert it to an integer.

 

    Example 1:

    Input: s = "III"
    Output: 3
    Explanation: III = 3.
     */

    /*
    #####################################################
    EXPLAINATION
    ####################################################

    This algorithm processes a Roman numeral string from right to left and calculates its integer value by considering both addition and subtraction rules.

    Steps to Convert Roman Numerals to Integer:

    1. Initialize Variables:
       - `total` stores the final integer value and starts at `0`.
       - `prevNum` keeps track of the last processed Roman numeral's value and starts at `0`.

    2. Iterate Through the Roman Numeral String (Right to Left):
       - Start from the last character of the string and move to the first.

    3. Get the Integer Value of the Current Roman Character:
       - Use a helper method (`getRomanToInteger`) to convert each Roman numeral character (like `'I'`, `'V'`) into its corresponding integer value (like `1`, `5`).

    4. Apply Addition or Subtraction:
       - If the current Roman numeral value is smaller than `prevNum`, subtract it from `total`. This handles subtraction cases like `'IV'` (4) or `'IX'` (9).
       - Otherwise, add it to `total`.

    5. Update `prevNum`:
       - Set `prevNum` to the current Roman numeral's value to compare it with the next character.

    6. Return the Total:
       - After the loop, `total` will contain the final integer value of the Roman numeral.

    Example Walkthrough

    Input: `"MCMXCIV"`

    Roman Numerals Breakdown:
    - `M = 1000`
    - `CM = 900` (Subtraction: `1000 - 100`)
    - `XC = 90` (Subtraction: `100 - 10`)
    - `IV = 4` (Subtraction: `5 - 1`)

    Detailed Step-by-Step Execution:

    1. Initialize:
       - `total = 0`
       - `prevNum = 0`

    2. Start iterating from the last character (`'V'` → `'M'`):

       Step 1: Process `'V'` (value = `5`)
       - `curNum = 5`
       - Since `curNum >= prevNum` (5 >= 0), add `5` to `total`.
       - `total = 5`, `prevNum = 5`

       Step 2: Process `'I'` (value = `1`)
       - `curNum = 1`
       - Since `curNum < prevNum` (1 < 5), subtract `1` from `total`.
       - `total = 4`, `prevNum = 1`

       Step 3: Process `'C'` (value = `100`)
       - `curNum = 100`
       - Since `curNum >= prevNum` (100 >= 1), add `100` to `total`.
       - `total = 104`, `prevNum = 100`

       Step 4: Process `'X'` (value = `10`)
       - `curNum = 10`
       - Since `curNum < prevNum` (10 < 100), subtract `10` from `total`.
       - `total = 94`, `prevNum = 10`

       Step 5: Process `'M'` (value = `1000`)
       - `curNum = 1000`
       - Since `curNum >= prevNum` (1000 >= 10), add `1000` to `total`.
       - `total = 1094`, `prevNum = 1000`

       Step 6: Process `'C'` (value = `100`)
       - `curNum = 100`
       - Since `curNum < prevNum` (100 < 1000), subtract `100` from `total`.
       - `total = 994`, `prevNum = 100`

       Step 7: Process `'M'` (value = `1000`)
       - `curNum = 1000`
       - Since `curNum >= prevNum` (1000 >= 100), add `1000` to `total`.
       - `total = 1994`, `prevNum = 1000`

    Final Output:
    - `total = 1994`

     */
    internal class RomanToInteger
    {

        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanToIntMap = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int total = 0;
            int prevNum = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int curNum = romanToIntMap[s[i]];
                if (curNum < prevNum)
                {
                    total -= curNum;
                }
                else
                {
                    total += curNum;
                }
                prevNum = curNum;
            }
            return total;
        }
        /// <summary>
        /// Below program uses switch statement to get specific int to roman value
        /// Space complexity is less here O(1)
        /// </summary>
        //public int RomanToInt(string s) {
        //    int total = 0;
        //    int prevNum = 0;
        //    for(int i=s.Length - 1; i >= 0; i--)
        //    {
        //        int curNum = getRomanToInteger(s[i]);
        //        if (curNum < prevNum)
        //        {
        //            total -= curNum;
        //        }
        //        else
        //        {
        //            total += curNum;
        //        }
        //        prevNum = curNum;
        //    }
        //    return total;
        //}
        //private int getRomanToInteger(char c)
        //{
        //    switch(c)
        //    {
        //        case 'I': return 1;
        //        case 'V': return 5;
        //        case 'X': return 10;
        //        case 'L': return 50;
        //        case 'C': return 100;
        //        case 'D': return 500;
        //        case 'M': return 1000;
        //        default:
        //            throw new ArgumentException("Match does not found");
        //    }
        //}

        public static void RunExample()
        {
            
            string romanNumber = "MCMXCIV";
            Console.WriteLine($"\n\nInput : {romanNumber}");
           
            var solution = new RomanToInteger();
            int result = solution.RomanToInt(romanNumber);
            Console.WriteLine($"\nResult (Roman To Integer): {result} \n");

            Console.WriteLine(ComplexityHelper.GetTimeComplexityBigON());
            Console.WriteLine(ComplexityHelper.GetSpaceComplexityBigON());
        }
    }
}
