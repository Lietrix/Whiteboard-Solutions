﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Solutions
{
    public class Whiteboard
    {
        public static int ThirdLargest(int[] x)
        {
            x[Array.IndexOf(x, x.Max())] = x.Min() - 1;//x[2] = 1
            x[Array.IndexOf(x, x.Max())] = x.Min() - 1;
            return x.Max();
        }


        public static void PhoneText(int numbers)
        {
            if (numbers.ToString().Length != 4 || numbers < 0)
            {
                throw new Exception();
            }

            int num1 = numbers / 1000;
            int num2 = numbers % 1000 / 100;
            int num3 = numbers % 1000 % 100 / 10;
            int num4 = numbers % 10;

            Dictionary<int, string> phone = new Dictionary<int, string>();
            phone.Add(0, "---");
            phone.Add(1, "---");
            phone.Add(2, "abc");
            phone.Add(3, "def");
            phone.Add(4, "ghi");
            phone.Add(5, "jkl");
            phone.Add(6, "mno");
            phone.Add(7, "prs");
            phone.Add(8, "yuv");
            phone.Add(9, "wxy");
            

            foreach (char x in phone.ElementAt(num1 - 1).Value)
            {
                foreach (char y in phone.ElementAt(num2 - 1).Value)
                {              
                    foreach (char z in phone.ElementAt(num3 - 1).Value)
                    {              
                        foreach (char v in phone.ElementAt(num4 - 1).Value)
                        {
                            Console.WriteLine($"{x}{y}{z}{v}");
                        }
                    }
                }
            }
        }
    }


}
