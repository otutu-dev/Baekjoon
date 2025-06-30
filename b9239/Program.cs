using System;
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
            decimal x = decimal.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            int start = 1, repeat = 10;

            string str = x.ToString();

            int xx = int.Parse(str[str.Length - 1].ToString());

            int num = -1;
            decimal mul;
            if(x == 1)
            {
                for (int i = start; i < repeat; i += start)
                {
                    result.Add(i);
                    if(i == repeat - 1 && repeat != 100000000)
                    {
                        start += repeat;
                        i = start;
                        repeat *= 10;
                        result.Add(i);
                    }
                }
                
            }
            else if(x < 10 && Math.Floor(x) != x)
            {
                start = 10; repeat = 100;
                if (xx == 5)
                {
                    for (int i = start; i < repeat; i += 2)
                    {
                        if (i / (start / 10) * x >= 100)
                        {
                            if (repeat == 100000000) break;
                            i = repeat;
                            start = repeat;
                            repeat *= 10;
                            continue;
                        }
                        
                        mul = i * x;
                        if (Math.Floor(mul) != mul) continue;
                        if (i / start == (int)mul % 10 && i % start == (int)mul / 10)
                        {
                            num = i;
                            break;
                        }
                    }
                }
                else if (xx % 2 == 0)
                {
                    for (int i = start; i < repeat; i += 5)
                    {
                        if (i / (start / 10) * x >= 100)
                        {
                            if (repeat == 100000000) break;
                            i = repeat;
                            start = repeat;
                            repeat *= 10;
                            continue;
                        }
                        
                        mul = i * x;
                        if (Math.Floor(mul) != mul) continue;
                        if (i / start == (int)mul % 10 && i % start == (int)mul / 10)
                        {
                            num = i;
                            break;
                        }
                    }
                } 
                else
                {
                    for(int i = start; i < repeat; i += 10)
                    {
                        if (i / (start / 10) * x >= 100)
                        {
                            if (repeat == 100000000) break;
                            i = repeat;
                            start = repeat;
                            repeat *= 10;
                            continue;
                        }

                        mul = i * x;
                        if (Math.Floor(mul) != mul) continue;
                        if (i / start == (int)mul % 10 && i % start == (int)mul / 10)
                        {
                            num = i;
                            break;
                        }
                    }
                }
            }
            
            
            if(result.Count != 0) foreach (int i in result) Console.WriteLine(i);
            else if(num == -1) Console.WriteLine("No solution");
            else
            {
                str = num.ToString();
                int numlen = str.Length;
                string str2 = str;

                int mulnum;

                decimal mulnumx;
                int mulnumxLength;
                while (num < 100000000)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        mulnum = num * i;
                        mulnumx = mulnum * x;
                        mulnumxLength = ((int)mulnumx).ToString().Length;
                        if (Math.Floor(mulnumx) == mulnumx && mulnumxLength == numlen)
                        {
                            if (int.Parse(mulnum.ToString()[1].ToString()) != 0)
                            {
                                result.Add(mulnum);
                            }
                        }
                    }
                    str2 += str;
                    numlen = str2.Length;
                    if (numlen > 8) break;
                    num = int.Parse(str2);
                }

                foreach (int i in result)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
