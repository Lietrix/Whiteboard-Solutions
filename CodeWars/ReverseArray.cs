using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class ReverseArray
    {
        static int[] Reverse(int[] input)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[input.Length - (i + 1)] = input[i];
            }

            foreach (var x in output)
            {
                Console.WriteLine(x);
            }
            return output;
        }
    }
}
