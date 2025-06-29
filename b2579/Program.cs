using System;

namespace b2579
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] score = new int[n+1];
            int[] mem1 = new int[n+1];
            int[] mem2 = new int[n+1];

            for (int i = 1; i < n+1; i++)
            {
                score[i] = int.Parse(Console.ReadLine());
            }

            mem1[1] = score[1];
            mem2[1] = score[1];

            for(int i = 2; i < n+1; i++)
            {
                mem1[i] = mem2[i - 1] + score[i];
                mem2[i] = Math.Max(mem2[i-2], mem1[i - 2]) + score[i];
            }

            Console.WriteLine(Math.Max(mem1[n], mem2[n]));
        }
    }
}
