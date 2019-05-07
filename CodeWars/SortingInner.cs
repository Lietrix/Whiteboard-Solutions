
using System.Linq;

using System.Collections.Generic;


namespace CodeWars
{
    class SortingInner
    {
        public static string SortTheInnerContent(string words)
        {
            string result = string.Empty;
            var sep = words.Split(' ');

            char temp1, temp2;

            foreach(var x in sep)
            {
                if(x.Length <= 2)
                {
                    result += x;
                    result += ' ';
                }
                else
                {
                    List<char> inner = x.ToList();

                    temp1 = inner.First();
                    temp2 = inner.Last();
                    inner.RemoveAt(0);
                    inner.RemoveAt(inner.Count - 1);
                    inner.Sort();
                    inner.Reverse();
                    string Inner = string.Empty;
                    foreach(var p in inner)
                    {
                        Inner += p;
                    }
                
                    result += $"{temp1}{Inner}{temp2} "; 
                }
            }
            return result.TrimEnd();
        }
    }
}
