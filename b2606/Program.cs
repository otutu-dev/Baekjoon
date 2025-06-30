using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace b2606
{
    internal class Program
    {
        static HashSet<int>[] netList;
        static bool[] visitList;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int comCount = int.Parse(sr.ReadLine());
            int netCount = int.Parse(sr.ReadLine());

            if (comCount <= 1 || netCount == 0) Console.WriteLine(0);
            else
            {
                netList = new HashSet<int>[comCount + 1];
                visitList = new bool[comCount + 1];

                for(int i = 1; i < comCount + 1; i++) 
                {
                    netList[i] = new HashSet<int>();
                }

                int[] inputArr = new int[2];

                for(int i = 0; i < netCount; i++)
                {
                    inputArr = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    netList[inputArr[0]].Add(inputArr[1]);
                    netList[inputArr[1]].Add(inputArr[0]);
                }

                Finder(1);

                int count = 0;
                for(int i = 2; i < comCount + 1; i++)
                {
                    if (visitList[i]) count++;
                }

                Console.WriteLine(count);

            }

            sr.Close();
        }

        static void Finder(int now)
        {
            visitList[now] = true;
            foreach(int i in netList[now]) if(!visitList[i]) Finder(i);
        }
    }
}
