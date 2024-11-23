using System;
using IrshadsLeetCodeSolutionsInCSharp.Problems.Arrays.Easy;

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
                Console.WriteLine("Choose a problem to run by entering its ID:");
                Console.WriteLine("Remember: Debugging and understanding the problem logic is key to mastering coding!");
                Console.WriteLine("1. TwoSum");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine() ?? string.Empty; ;

                switch (choice)
                {
                    case "1":
                        TwoSumSolution.RunExample();
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
