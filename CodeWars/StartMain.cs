using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class StartMain
    {
        public static void Main(string[] args)
        {
            /*
            //Takes an input integer and returns the number in descending order based on each individual digit
            Console.WriteLine("7143543 in descending order based on digit is ");
            Console.WriteLine(Kata.DescendingOrder(7143543)+ "\n");

            //Reverses an array
            Console.WriteLine("1, 4, 5, 3, 2, 6 in reverse order is");
            ReverseArray.Reverse(new int[]{ 1, 4, 5, 3, 2, 6});

            //Rotates each character in a string 13 characters
            Console.WriteLine("\nMary had a little lamb; rotated 13 characters is : " + kata.Rot13("Mary had a little lamb") + "\n");

            //Changes a string into its WeIrDcAsE fOrMaT
            Console.WriteLine("Now in wEiRdCaSe!\n" + WeirdCase.ToWeirdCase("Mary had a little lamb"));
            */

            string[] directions = { "NORTH", "SOUTH", "EAST", "EAST", "SOUTH", "EAST", "WEST", "NORTH", "EAST" };
            Console.WriteLine("Expected Result : EAST, EAST, EAST");
            Console.WriteLine("Actual Result : ");
            foreach(var y in ClearDirection.dirReduc(directions))
            {
                Console.Write(y + ", ");
            }
            Console.ReadLine();
                

        }
    }
}
