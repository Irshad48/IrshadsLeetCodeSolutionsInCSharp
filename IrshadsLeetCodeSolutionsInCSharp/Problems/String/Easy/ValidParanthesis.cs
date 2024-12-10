using IrshadsLeetCodeSolutionsInCSharp.Problems.HashTable.Easy;
using IrshadsLeetCodeSolutionsInCSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrshadsLeetCodeSolutionsInCSharp.Problems.String.Easy
{
    /*
       **********************************************************
       PROBLEM STATEMENT
       **********************************************************

         20. Valid Parentheses
        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.

        Example 1:
        Input: s = "()"
        Output: true

        Example 2:
        Input: s = "()[]{}"
        Output: true

        Example 3:
        Input: s = "(]"
        Output: false

        Example 4:
        Input: s = "([])"
        Output: true

        Constraints:
        1 <= s.length <= 104
        s consists of parentheses only '()[]{}'.
        */
    /*
    ############################################################  
    APPROACH - 1
    ############################################################   
    */

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
    
    The provided code determines whether a string of brackets (`()`, `{}`, `[]`) is valid based on the following conditions:
    1. Each opening bracket must have a corresponding and correctly placed closing bracket.
    2. Brackets must be closed in the correct order.

    Step-by-Step Explanation**

    1. Edge Case Handling.        
       if (string.IsNullOrEmpty(s))
           return true;
       
       - If the input string is empty (`""`) or null, it is considered valid since there are no unmatched brackets. The method returns `true` immediately.       

    2. Using a Stack.        
       Stack<char> stack = new Stack<char>();
       
       - A stack is used to keep track of unmatched opening brackets. A **stack** works on the **Last-In-First-Out (LIFO)** principle, which is ideal for bracket matching because the most recent opening bracket needs to be closed first.    

    3. Iterate Through the Characters.        
       foreach (char c in s)
       
       - Each character in the input string is processed sequentially.    

    4. Handle Opening Brackets.        
       if (c == '(')
           stack.Push(')');
       else if (c == '[')
           stack.Push(']');
       else if (c == '{')
           stack.Push('}');
       
       - If the current character is an opening bracket (`(`, `{`, `[`), push the **expected closing bracket** (`)`, `}`, `]`) onto the stack.
       - This means the stack contains only expected closing brackets.    

    5. Handle Closing Brackets.        
       else if (stack.Count == 0 || stack.Pop() != c)
           return false;
       
       - If the current character is a closing bracket:
         - **Check if the stack is empty. 
           - If yes, it means there’s no corresponding opening bracket for this closing bracket. Return `false`.
         - **Compare the top of the stack. 
           - If the top element (expected closing bracket) does not match the current character, the brackets are mismatched. Return `false`.
       - If the match is successful, `Pop` removes the top element from the stack.    

    6. Final Validation.        
       return stack.Count == 0;
       
       - After processing all characters, the stack should be empty if all opening brackets were matched by their corresponding closing brackets.
       - If the stack is not empty, it means some opening brackets remain unmatched, so the method returns `false`.    

     Example Execution

    # Input: `"({[]})"`

    1. Initialize. 
       - Stack: `[]`

    2. Process Each Character. 
       - `'('`: Push `')'` onto the stack.
         - Stack: `[')']`
       - `'{'`: Push `'}'` onto the stack.
         - Stack: `[')', '}']`
       - `'['`: Push `']'` onto the stack.
         - Stack: `[')', '}', ']']`
       - `']'`: Pop and compare with `']'`. Matches.
         - Stack: `[')', '}']`
       - `'}'`: Pop and compare with `'}'`. Matches.
         - Stack: `[')']`
       - `')'`: Pop and compare with `')'`. Matches.
         - Stack: `[]`

    3. Final Validation. 
       - Stack: `[]`
       - Return `true`.    

    # Input: `"([)]"`

    1. Initialize. 
       - Stack: `[]`

    2. Process Each Character. 
       - `'('`: Push `')'` onto the stack.
         - Stack: `[')']`
       - `'['`: Push `']'` onto the stack.
         - Stack: `[')', ']']`
       - `')'`: Pop and compare with `')'`. Matches.
         - Stack: `[')']`
       - `']'`: Pop and compare with `']'`. Mismatch.  
         - Return `false`.    

    # Input: `"((("`

    1. Initialize. 
       - Stack: `[]`

    2. Process Each Character. 
       - `'('`: Push `')'` onto the stack.
         - Stack: `[')']`
       - `'('`: Push `')'` onto the stack.
         - Stack: `[')', ')']`
       - `'('`: Push `')'` onto the stack.
         - Stack: `[')', ')', ')']`

    3. Final Validation. 
       - Stack: `[')', ')', ')']` (Not empty).
       - Return `false`.    

     Why This Approach is Efficient
    1. Direct Matching. 
       - Expected closing brackets are pushed directly onto the stack, eliminating the need for a separate helper function.
    2. Early Exit. 
       - Mismatches or invalid strings are detected as soon as possible, without processing the entire string unnecessarily.
    3. Clean and Concise. 
       - Fewer operations and straightforward logic make this implementation compact and easy to maintain.
    */

    /*
    ############################################################
    APPROACH 1 - CODE
    ############################################################
    */
    internal class ValidParanthesis
    {
        /// <summary>
        /// It uses stack and most efficient approach to solve the problem
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '[')
                    stack.Push(']');
                else if (c == '{')
                    stack.Push('}');

                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }
            return stack.Count == 0;
        }
        public static void RunExample()
        {

            string paranthesis = "()[]{}";
            Console.WriteLine($"\n\nInput : {paranthesis}");

            var solution = new ValidParanthesis();
            bool result = solution.IsValid(paranthesis);
            Console.WriteLine($"\nResult (Valid Paranthesis): {result} \n");

            Console.WriteLine(ComplexityHelper.GetTimeComplexityBigON());
            Console.WriteLine(ComplexityHelper.GetSpaceComplexityBigON());
        }

    }
}
