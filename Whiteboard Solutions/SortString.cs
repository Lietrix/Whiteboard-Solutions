using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Solutions
{
    public class SortString
    {
        public static string sorted(string P)
        {
            string sort = string.Empty;
            int length = P.Length;
            for (int i = 0; i < length; i++)
            {
                sort += P.Min();
                P = P.Remove(P.IndexOf(P.Min()), 1);
            }
            return sort;
        }
    }   
}
