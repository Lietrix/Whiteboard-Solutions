using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class kata
    {
        public static string Rot13(string message)
        {
            string output = string.Empty;
            string a = "abcdefghijklmnopqrstuvwxyz";
                
            foreach (char c in message)
            {
                if (Char.IsUpper(c))
                {
                    char temp = Char.ToLower(c);
                    int shift = Array.IndexOf(a.ToCharArray(), temp) + 13;
                    if (shift > a.Length - 1)
                    {
                        shift -= a.Length;
                        output += a[shift].ToString().ToUpper();
                        continue;
                    }
                    output += a[shift].ToString().ToUpper();
                    continue;
                }
                if (!a.Contains(c))
                {
                    output += c;
                    continue;
                }
                else
                {
                    int shift = Array.IndexOf(a.ToCharArray(),c) + 13;
                    if (shift > a.Length-1)
                    {
                        shift -= a.Length;
                        output += a[shift];
                        continue;
                    }
                    output += a[shift];
                }
            }
            return output;
        }
    }
}
