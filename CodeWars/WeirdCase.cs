using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class WeirdCase
    {
        public static string ToWeirdCase(string s)
        {
            if (s == "" || s == null)
            {
                return s;
            }
            string output = string.Empty;
            int i = 0;

            // Only checking until the first character.
            while (s[i] == ' ' || s[i] == ',' || s[i] == '!' || s[i] == '.')
            {
               
                if (i >= s.Length)
                {
                    break;
                }
                output += s[i];
                i++;
                if (i > s.Length - 1)
                {
                    break;
                }
            }

            // Starts the first character of a string in caps
            int x = 2;
            while (i < s.Length)
            {
                if (x % 2 == 0)
                {

                    if (s[i] == ' ' || s[i] == ',' || s[i] == '!' || s[i] == '.')
                    {
                        output += s[i];
                        x = 2;
                        i++;
                        continue;
                    }
                    output += s[i].ToString().ToUpper();
                    i++;
                    x++;

                }

                else
                {

                    if (s[i] == ' ' || s[i] == ',' || s[i] == '!' || s[i] == '.')
                    {
                        output += s[i];
                        x = 2;
                        i++;
                        continue;
                    }
                    output += s[i].ToString().ToLower();
                    i++;
                    x++;
                }
            }
            return output;
        }
    }
}
