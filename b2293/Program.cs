using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2293
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] dp = new int[k + 1];
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nums);

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < k + 1; j++)
                {
                    if (j == nums[i]) dp[j]++;
                    if (j > nums[i])
                    {
                        dp[j] += dp[j - nums[i]];
                    }
                }
            }

            Console.WriteLine(dp[k]);

        }
    }
}
