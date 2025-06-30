using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b9239
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1.1524;
            int i = 11302500;
            double mul = i * x;
            Console.WriteLine(mul);
            Console.WriteLine(mul % 1 == 0.0);
            if (Math.Floor(mul) != mul) Console.WriteLine("continue");
            if ( i / 10000000 == (int)mul % 10 && i % 10000000 == (int)mul / 10)
            {
                Console.WriteLine("found: " + i);
            }
            //double x = double.Parse(Console.ReadLine());
            //List<int> result = new List<int>();

            //int start = 1, repeat = 10;

            //string str = x.ToString();

            //int xx = int.Parse(str[str.Length - 1].ToString());

            //double mul;
            //if (x == 1)
            //{
            //    for (int i = start; i < repeat; i += start)
            //    {
            //        result.Add(i);
            //        if (i == repeat - 1 && repeat != 100000000)
            //        {
            //            start += repeat;
            //            i = start;
            //            repeat *= 10;
            //            result.Add(i);
            //        }
            //    }

            //}
            //else if (x < 10 && x % 1 != 0 && str.IndexOf('.') != -1)
            //{
            //    start = 10; repeat = 100;
            //    if (xx == 5)
            //    {
            //        for (int i = start; i < repeat; i += 2)
            //        {
            //            if ((i / (start / 10) * x >= 100))
            //            {
            //                if (repeat == 100000000) break;
            //                i = repeat;
            //                start = repeat;
            //                repeat *= 10;
            //                continue;
            //            }

            //            mul = i * x;
            //            if (mul % 1 != 0) continue;
            //            if (i / start == (int)mul % 10 && i % start == (int)mul / 10)
            //                result.Add(i);
            //        }
            //    }
            //    else if (xx % 2 == 0)
            //    {
            //        for (int i = start; i < repeat; i += 5)
            //        {
            //            if ((i / (start / 10) * x >= 100))
            //            {
            //                if (repeat == 100000000) break;
            //                i = repeat;
            //                start = repeat;
            //                repeat *= 10;
            //                continue;
            //            }

            //            mul = i * x;
            //            if (mul % 1 != 0) continue;
            //            if (i / start == (int)mul % 10 && i % start == (int)mul / 10)
            //                result.Add(i);
            //        }
            //    }
            //}

            //if (result.Count == 0) Console.WriteLine("No solution");
            //else
            //{
            //    foreach (int i in result)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


        }
    }
}
