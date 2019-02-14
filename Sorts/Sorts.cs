using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Sorts
    {
        public static void BubbleSort(int[] num)
        {
            for (int i = 0; i < num.ToString().Length - 1; i++)
            {
                for (int j = 0; j < num.ToString().Length - 1; j++)
                {
                    if (num[j] < num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
        }
    }
}
