using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Solutions
{
    class SumOfAllPrimes
    {
        public static int SumOfPrimes(int x)
        {
            int result = 0;
            for (int i = 2; i <= x; i++)
            {
                if (isPrime(i)) result += i;
            }
            return result;
        }
        static bool isPrime(int x)
        {
            if (x <= 1) return false;
            if (x == 2) return true;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
