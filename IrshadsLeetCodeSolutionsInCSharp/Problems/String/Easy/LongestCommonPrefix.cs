using IrshadsLeetCodeSolutionsInCSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrshadsLeetCodeSolutionsInCSharp.Problems.String.Easy
{
    internal class LongestCommonPrefix
    {
        /*
        ************************************************************
        PROBLEM STATEMENT
        ************************************************************
        
        14. Longest Common Prefix
        Write a function to find the longest common prefix string amongst an array of strings.

        If there is no common prefix, return an empty string "".
        
        Example 1:

        Input: strs = ["flower","flow","flight"]
        Output: "fl"
        Example 2:

        Input: strs = ["dog","racecar","car"]
        Output: ""
        Explanation: There is no common prefix among the input strings.
 

        Constraints:

        1 <= strs.length <= 200
        0 <= strs[i].length <= 200
        strs[i] consists of only lowercase English letters.
         */
        /*
        ############################################################
        APPROACH - 1
        ############################################################
        */
        /// <summary>
        /// Horizontal Scanning Approach for Longest Common Prefix - Specially helpful in case of large input size
        /// This approach iteratively compares characters of all strings in the input array horizontally. 
        /// Starting from the first character of the first string, it checks whether this character is present at the same position in all other strings. 
        /// If it is, it moves to the next character, and so on.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        /*
        ############################################################
        COMPLEXITIES
        ############################################################
        Time Complexity - O(n)
        Space Complexity - O(1)
        */

        /*
        ############################################################
        EXPLAINATION
        ############################################################

        Step-by-Step Execution:

        1. Check Base Case:
   
           if (strs == null || strs.Length == 0) return "";
   
           - If the array is null or empty, there is no prefix. Return an empty string immediately.
           - Example: If strs = [], the output is "".

        2. Assume the First String is the Prefix:
   
           string prefix = strs[0];
   
           - Start by assuming the first string ("flower") is the longest common prefix.
           - Example: prefix = "flower"

        3. Loop Through the Remaining Strings:
   
           for (int i = 1; i < strs.Length; i++) {
   
           - Compare the current prefix with each subsequent string in the array.
           - Example: Compare "flower" with "flow", then "flight".

        4. Check if the Current String Starts with the Prefix:
   
           while (strs[i].IndexOf(prefix) != 0) {
   
           - Use IndexOf to check if the prefix exists at the start of strs[i].
           - If the prefix doesnt match, reduce it character by character.

        5. Shorten the Prefix:
   
           prefix = prefix.Substring(0, prefix.Length - 1);
   
           - Reduce the prefix by removing the last character.
           - Example:
             - Start with "flower".
             - Check "flow": Prefix becomes "flow".
             - Check "flight": Prefix becomes "fl".

        6. Return Empty String if Prefix Becomes Empty:
   
           if (prefix == "") return "";
   
           - If the prefix is reduced to an empty string, it means there is no common prefix among the strings.

        7. Return the Final Prefix:
   
           return prefix;
   
           - The final value of prefix is the longest common prefix.
           - Example:
             - After comparing "flower", "flow", and "flight", the prefix is "fl".

        ---------

        Example Walkthrough:

        Input: 
        plaintext
        strs = ["flower", "flow", "flight"]


        - Start: prefix = "flower"

        1. Compare with "flow":
           - "flow".IndexOf("flower") != 0: Shorten "flower" to "flow".
           - "flow".IndexOf("flow") == 0: Prefix is "flow".

        2. Compare with "flight":
           - "flight".IndexOf("flow") != 0: Shorten "flow" to "flo", then "fl".
           - "flight".IndexOf("fl") == 0: Prefix is "fl".

        Output:
        plaintext
        "fl"

        */

        /*
        ############################################################
        APPROACH 1 - CODE
        ############################################################

        */
        //public string LongestCommonPrefixMethod1(string[] strs)
        //{
        //    if (strs.Length == 0 && strs == null) return "";

        //    string prefix = strs[0];
        //    for (int i = 1; i < strs.Length; i++)
        //    {
        //        while (strs[i].IndexOf(prefix) != 0)
        //        {
        //            prefix = prefix.Substring(0, prefix.Length - 1);
        //        }
        //    }
        //    return prefix;
        //}

        /*
        ############################################################
        APPROACH - 2 
        ############################################################
        */
        /*
        The given method, `LongestCommonPrefixMethod1`, uses sorting and comparison to find the longest common prefix among a list of strings. Here’s a detailed explanation of the approach, followed by an example.

        Approach Explanation

        1. Handle Edge Cases  
           - If the input array is empty (`strs.Length == 0`) or null (`strs == null`), return an empty string (`""`).

        2. Sort the Array  
           - Sorting arranges strings lexicographically (dictionary order). This guarantees that the strings with the most differences will be placed at the two ends of the array.  
             Example: For `["flower", "flow", "flight"]`, sorting results in:  
             ```plaintext
             ["flight", "flow", "flower"]
             ```

        3. Compare First and Last Strings  
           - The first and last strings after sorting will have the least in common.
           - By comparing these two strings character by character, we can determine the longest common prefix for the entire array.  
           - If these two strings are identical, return the string itself as the prefix.

        4. Build the Common Prefix  
           - Use a loop to compare characters at each position between the first and last strings.
           - Stop when a mismatch is found, and add all matching characters to the prefix using a `StringBuilder`.

        5. Return the Result  
           - Convert the `StringBuilder` to a string and return it as the longest common prefix.

        ---

         Step-by-Step Example

         Input:
        ```plaintext
        strs = ["flower", "flow", "flight"]
        ```

         Execution:
        1. Initial Input  
           ```plaintext
           strs = ["flower", "flow", "flight"]
           ```

        2. Sort the Array  
           After sorting:  
           ```plaintext
           strs = ["flight", "flow", "flower"]
           ```

        3. Identify First and Last Elements  
           ```plaintext
           firstElement = "flight"
           lastElement = "flower"
           ```

        4. Compare Characters  
           - Start comparing `firstElement` and `lastElement` character by character:
             ```plaintext
             Compare 'f' == 'f' → Match → Add 'f' to StringBuilder.
             Compare 'l' == 'l' → Match → Add 'l' to StringBuilder.
             Compare 'i' != 'o' → Mismatch → Stop.
             ```
           - The matching characters are `"fl"`.

        5. Return the Result  
           ```plaintext
           Longest Common Prefix = "fl"
           ```

       Key Observations
        1. Sorting ensures that we only need to compare two strings (first and last), significantly simplifying the problem.
        2. This approach is efficient because:
           - Comparing two strings character by character is faster than comparing all strings in the array.
           - Sorting helps to bring the least common elements to the extreme ends.

        

         */
        /*
        ############################################################
                COMPLEXITIES
        ############################################################
        Time Complexity - O(nlogn)
        Space Complexity - O(1)
        */
        /*
        ############################################################
        APPROACH - 2 CODE
        ############################################################
         */

        public string LongestCommonPrefixMethod1(string[] strs)
        {
            if (strs.Length == 0 && strs == null) return "";

            StringBuilder sb = new StringBuilder(); 

            Array.Sort(strs);
            string firstElement = strs[0];
            string lastElement = strs[strs.Length - 1];

            if (firstElement == lastElement)
                return firstElement;

            for (int i = 0; i < strs.Length - 1; i++)
            {
                if (firstElement[i] != lastElement[i])
                    break;
                sb.Append(firstElement[i]);
            }

            return sb.ToString();
        }
        public static void RunExample()
        {

            string displayInput = "[flower,flow,flight]";
            Console.WriteLine($"\n\nInput : {displayInput}");

            string[] strs = { "flower", "flow", "flight" };
            var solution = new LongestCommonPrefix();
            string result = solution.LongestCommonPrefixMethod1(strs);
            Console.WriteLine($"\nResult : {result} \n");

            Console.WriteLine(ComplexityHelper.GetTimeComplexityBigONLogN());
            Console.WriteLine(ComplexityHelper.GetTimeComplexityBigO1());
        }
    }
}
