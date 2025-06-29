using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1978
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');
            int[] num = new int[n];

            for(int i = 0; i < n; i++)
            {
                num[i] = int.Parse(arr[i]);
            }

            int count = 0;
            
            for(int i = 0; i < n; i++)
            {
                bool check = true;
                if (num[i] == 1) check = !check;
                for(int j = 2; j <= Math.Sqrt(num[i]); j++)
                {
                    if (num[i] % j == 0)
                    {
                        check = !check;
                        break;
                    }
                }
                if (check) count++;
            }

            Console.WriteLine(count);
        }
    }
}
