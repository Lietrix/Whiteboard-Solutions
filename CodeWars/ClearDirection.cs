using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    //    … A man was given directions to go from one point to another.
    //    The directions were "NORTH", "SOUTH", "WEST", "EAST".
    //    Clearly "NORTH" and "SOUTH" are opposite, "WEST" and "EAST" too.
    //    Going to one direction and coming back the opposite 
    //    direction is a needless effort.
    class ClearDirection
    {
        public static string[] dirReduc(String[] arr)
        {
            List<string> result = new List<string>();

            foreach(var i in arr)
            {
                if (i == "SOUTH" && result.Contains("NORTH") && result.Last() == "NORTH")
                    result.RemoveAt(result.LastIndexOf("NORTH"));
                else if (i == "NORTH" && result.Contains("SOUTH") && result.Last() == "SOUTH")
                    result.RemoveAt(result.LastIndexOf("SOUTH"));
                else if (i == "WEST" && result.Contains("EAST") && result.Last() == "EAST")
                    result.RemoveAt(result.LastIndexOf("EAST"));
                else if (i == "EAST" && result.Contains("WEST") && result.Last() == "WEST")
                    result.RemoveAt(result.LastIndexOf("WEST"));
                else
                    result.Add(i);
            }
            return result.ToArray();
        }
    }
}
