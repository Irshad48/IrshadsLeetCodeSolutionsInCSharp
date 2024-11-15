using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrshadsLeetCodeSolutionsInCSharp.Problems.Arrays.Easy
{
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
            string userInput = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrEmpty(userInput) || userInput == "yes")
            {
                // Use static/default input
                int[] nums = { 2, 7, 11, 15 };
                int target = 9;

                Console.WriteLine("Using default inputs:");
                Console.WriteLine($"Array: [{string.Join(", ", nums)}], Target: {target}");

                var solution = new TwoSumSolution();
                int[] result = solution.TwoSum(nums, target);

                Console.WriteLine($"Result: Indices of numbers that add up to {target}: [{result[0]}, {result[1]}]");
            }
            else if (userInput == "no")
            {
                // Use custom input
                Console.WriteLine("Enter array of integers (comma-separated): ");
                var input = Console.ReadLine();
                int[] nums = Array.ConvertAll(input.Split(','), int.Parse);

                Console.WriteLine("Enter the target integer: ");
                int target = int.Parse(Console.ReadLine());

                var solution = new TwoSumSolution();
                int[] result = solution.TwoSum(nums, target);

                Console.WriteLine($"Result: Indices of numbers that add up to {target}: [{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("Invalid input. Running with default inputs.");
                int[] nums = { 2, 7, 11, 15 };
                int target = 9;

                Console.WriteLine($"Array: [{string.Join(", ", nums)}], Target: {target}");

                var solution = new TwoSumSolution();
                int[] result = solution.TwoSum(nums, target);

                Console.WriteLine($"Result: Indices of numbers that add up to {target}: [{result[0]}, {result[1]}]");
            }


            //Console.WriteLine("Example: Two Sum Problem");
            //Console.WriteLine("Input Array:  2, 7, 11, 15 ");
            //Console.WriteLine("Taget: 9 ");
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;

            //var solution = new TwoSumSolution();
            //int[] result = solution.TwoSum(nums, target);

            //Console.WriteLine("Result: ");
            //Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }
}
