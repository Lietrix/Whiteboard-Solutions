using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Solutions
{
    class Test
    {
        public static void Main(string[] args)
        {
            //Inputs a string, and returns the string in alphabetical order
            Console.WriteLine("apple sorted alphabettically is : " +SortString.sorted("apple"));

            //Returns true or false if the input string a is palidrome or not
            Console.WriteLine("This is testing if - racecar - is a palidrome");
            Console.WriteLine(IsPalidrome.palidrome("racecar") + "\n\n");

            Console.WriteLine("This is test if - apple -  is a palidrome");
            Console.WriteLine(IsPalidrome.palidrome("apple") + "\n\n");

            //Returns the total sum of prime numbers that are less than the given number
            Console.WriteLine("The sum of all prime numbers for 110 is " + SumOfAllPrimes.SumOfPrimes(110));

            //Checks a number is prime or not
            Console.WriteLine("Is 61 a prime number? " + SumOfAllPrimes.isPrime(7));

            //Returns the 3rd largest number in an integer array
            Console.WriteLine("\nThe thirdlargest number in { 1, 5, 19, 1, 17, 612, 54, 65} is : "
                + Whiteboard.ThirdLargest(new int[] { 1, 5, 19, 1, 17, 612, 54, 65 }) + "\n");

            //Input 4 numbers and returns all the possible lettering with the old phone keys
            Console.WriteLine("This will return all the possbile texts you can write with these 4 numbers \nType 4 numbers :");
            Whiteboard.PhoneText(Int32.Parse(Console.ReadLine()));
            
            
        }
    }
}
