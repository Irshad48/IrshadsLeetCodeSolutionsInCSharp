using IrshadsLeetCodeSolutionsInCSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IrshadsLeetCodeSolutionsInCSharp.Problems.Arrays.Easy
{    
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.

    //Example 1:
    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0, 1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    internal class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var numToIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numToIndex.ContainsKey(complement))
                {
                    return new int[] { numToIndex[complement], i };
                }
                numToIndex[nums[i]] = i;
            }

            throw new ArgumentException("No two sum solution found");
        }

        // Example usage of TwoSum solution
        public static void RunExample()
        {
            Console.WriteLine("Do you want to use default inputs (yes/no)? Default inputs will run automatically if no option is provided.");
            string userInput = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
            
            bool useDefaultInput = string.IsNullOrEmpty(userInput) || userInput == "yes";

            int[] nums;
            int target;

            if (useDefaultInput)
            {
                nums = new[] { 2, 7, 11, 15 };
                target = 9;
                Console.WriteLine("Using default inputs:");
            }
            else
            {
                Console.WriteLine("Enter array of integers (comma-separated): ");
                var input = Console.ReadLine() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(input)) throw new ArgumentException("Array input cannot be null or empty.");

                nums = Array.ConvertAll(input.Split(','), int.Parse);

                Console.WriteLine("Enter the target integer: ");
                string? input1 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input1))
                {
                    throw new ArgumentException("Target input cannot be null or empty.");
                }
                target = int.Parse(input1);
            }

            Console.WriteLine($"Array: [{string.Join(", ", nums)}], Target: {target}");

            var solution = new TwoSumSolution();
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"Result: Indices of numbers that add up to {target}: [{result[0]}, {result[1]}]");

            Console.WriteLine(ComplexityHelper.GetTimeComplexityBigON());
            Console.WriteLine(ComplexityHelper.GetSpaceComplexityBigON());
        }
    }
}
