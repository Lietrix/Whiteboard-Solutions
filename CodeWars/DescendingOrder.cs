using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Kata
    {
        // --- CONVERTS AN INT INTO AN ARRAY --
        public static int[] ConvertInt(int input)  
        {
            int[] output = new int[input.ToString().Length];
            int i = 0;
            while (input > 0) 
            {
                output[i] = input % 10;
                input /= 10;
                i++;
            }
            return output;
        }


        public static int DescendingOrder(int num)
        {
            int [] num1 = ConvertInt(num);
            for (int i = 0; i < num.ToString().Length - 1; i++)
            {
                for (int j = 0; j < num.ToString().Length - 1; j++)
                {   
                    if(num1[j] < num1[j + 1])
                    {

                    int temp = num1[j];
                    num1[j] = num1[j + 1];
                    num1[j + 1] = temp;

                    }
                }
            }

            string result = String.Empty;
            for (int i = 0; i < num1.Length; i++)
            {
                result += num1[i];
            }

            return Int32.Parse(result);
   

        }
    }
}
    


