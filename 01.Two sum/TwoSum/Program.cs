using System;
using System.Text.RegularExpressions;

namespace TwoSum1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());

            int[] result = TwoSum(numbers, target);
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
        static int[] TwoSum(int[] nums, int target)
        {

            int[] intArr = new int[2];
            for (int i = 0; i < nums.Length - 1; i++) // 1 2 3 4 5
            {
                for (int j = 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        intArr[0] = i;
                        intArr[1] = j;
                        break;
                    }
                }
            }
            return intArr;
        }

    }

}
