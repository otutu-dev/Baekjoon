using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string[] arr = sr.ReadLine().Split(' ');
            int n = int.Parse(arr[0]);
            int m = int.Parse(arr[1]);
            int[] cards = new int[n];

            arr = sr.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                cards[i] = int.Parse(arr[i]);
            }

            int max = 0, sum = 0;

            for (int i = 0; i < n - 2; i++)
            {
                for(int j = i + 1; j < n - 1; j++)
                {
                    for(int k = j + 1; k < n; k++)
                    {
                        sum = cards[i] + cards[j] + cards[k];
                        if (sum <= m) max = Math.Max(max, sum);
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}
