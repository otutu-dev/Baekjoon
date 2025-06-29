using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int count = 0;

            for(int i = 1; i <= num; i++)
            {
                int sum = 0;
                for(int j = i; j <= num; j++)
                {
                    sum += j;
                    if (sum > num) break;
                    if(sum == num)
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
