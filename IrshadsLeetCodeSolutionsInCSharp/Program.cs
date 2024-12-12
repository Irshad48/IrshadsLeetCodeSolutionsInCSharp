using System;
using IrshadsLeetCodeSolutionsInCSharp.Problems.Arrays.Easy;
using IrshadsLeetCodeSolutionsInCSharp.Problems.HashTable.Easy;
using IrshadsLeetCodeSolutionsInCSharp.Problems.LinkedList.Easy;
using IrshadsLeetCodeSolutionsInCSharp.Problems.String.Easy;

namespace IrshadsLeetCodeSolutionsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear();  // Clear the screen for a fresh menu display
                Console.WriteLine("Welcome to Irshad's LeetCode Solutions in C#!");                
                Console.WriteLine("Remember: Debugging and understanding the problem logic is key to mastering coding!\n");
                Console.WriteLine("########################## MOST IMP PART BELOW ##########################");
                Console.WriteLine("Each class file holds the problem description and examples. The goal? Think, Solve, debug, and conquer coding challenges like a pro!\n");
                Console.WriteLine("Choose a problem to run by entering its ID:");
                Console.WriteLine("1. TwoSum");
                Console.WriteLine("13. RomanToInteger (2 approach - chk code)");
                Console.WriteLine("14. LongestCommonPrefix (2 approach - chk code)");
                Console.WriteLine("20. ValidParanthesis ");
                Console.WriteLine("21. MergeTwoSortedList ");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine() ?? string.Empty; ;

                switch (choice)
                {
                    case "1":
                        TwoSumSolution.RunExample();
                        break;
                    case "13":
                        RomanToInteger.RunExample();
                        break;
                    case "14":
                        LongestCommonPrefix.RunExample();
                        break;
                    case "20":
                        ValidParanthesis.RunExample();
                        break;
                    case "21":
                        MergeTwoSortedList.RunExample();
                        break;
                    case "0":
                        continueRunning = false;  // Exit the loop and close the program
                        Console.WriteLine("Exiting... Thank you for using Irshad's LeetCode Solutions!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice or problem ID not yet implemented.");
                        break;
                }

                if (continueRunning)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();  // Wait for user to press a key before going back to the menu
                }
            }
        }
    }
}
