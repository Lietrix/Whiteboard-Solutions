using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Solutions
{
    class Whiteboard
    {
        public static void Main(string[] args)
        {
            int[] test = { 7, 3, 33, 4, 3, 2, 4, 7, 8 };
            int x = ThirdLargest(test);
            Console.WriteLine(x);
        }

        public static int ThirdLargest(int[] x)
        {
            x[Array.IndexOf(x, x.Max())] = x.Min() - 1;
            x[Array.IndexOf(x, x.Max())] = x.Min() - 1;
            return x.Max();
        }
    }


}
