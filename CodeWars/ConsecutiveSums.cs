using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    //You are given a list/array which contains only integers (positive and negative).
    //Your job is to sum only the numbers that are the same and consecutive. 
    //The result should be one list.

    // example: [1,4,4,4,0,4,3,3,1] should return [1,12,0,4,6,1]

    class ConsecutiveSums
    {
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> result = new List<int>();
            int y = 0;
            foreach (int x in s)
            {
                if (y != 0)
                {
                    y = x;
                }

                if (x == s.IndexOf(x) - 1)
                {
                    y += x;
                }

                else
                {
                    result.Add(y);
                    y = 0;
                }
            }
            return result;
        }
    }
}
