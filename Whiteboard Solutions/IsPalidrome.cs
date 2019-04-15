using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Solutions
{
    public class IsPalidrome
    {
        public static bool palidrome(string x)
        {
            string y = string.Empty;
            for (int i = x.Length - 1; i >= 0; i--) y += x[i];
            return y == x;
        }
    }
}
