using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class CountUTF_8
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> output = new Dictionary<char, int> { };
            foreach(char x in str)
            {
                if (!output.ContainsKey(x))
                {
                    output.Add(x, 1);
                }
                else
                {
                    output[x]++;
                }
                
            }
            return output;
        }
    }
}
