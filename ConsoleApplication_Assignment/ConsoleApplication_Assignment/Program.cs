using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:"); // Asking user for input
            double num1 = Convert.ToDouble(Console.ReadLine()); // Converting string output to a double data type variable
            double numMult = num1 * 50; // Performing a multiplication operation on user input
            Console.WriteLine(num1.ToString() + " multiplied by 50 = " + numMult.ToString()); // Converting variables back to strings and displaying concatenated string to user

            Console.WriteLine("\nPlease enter a number:"); // Asking user for input
            double num2 = Convert.ToDouble(Console.ReadLine()); // Converting string output to a double data type variable
            double numAdd = num2 + 25; // Performing an addition operation on user input
            Console.WriteLine(num2.ToString() + " plus 25 = " + numAdd.ToString());  // Converting variables back to strings and displaying concatenated string to user

            Console.WriteLine("\nPlease enter a number:"); // Asking user for input
            double num3 = Convert.ToDouble(Console.ReadLine()); // Converting string output to a double data type variable
            double numDiv = num3 / 12.5; // Performing a division operation on user input
            Console.WriteLine(num3.ToString() + " divided by 12.5 = " + numDiv.ToString());  // Converting variables back to strings and displaying concatenated string to user

            Console.WriteLine("\nPlease enter a number:"); // Asking user for input
            double num4 = Convert.ToDouble(Console.ReadLine()); // Converting string output to a double data type variable
            bool numBool = num4 > 50; // Performing a boolean operation on user input
            Console.WriteLine("Is " + num4.ToString() + " greater than 50?" + "\nAnswer: " + numBool.ToString());  // Converting variables back to strings and displaying concatenated string to user

            Console.WriteLine("\nPlease enter a number:"); // Asking user for input
            double num5 = Convert.ToDouble(Console.ReadLine()); // Converting string output to a double data type variable
            double numRemainder = num5 % 7; // Performing a remainder operation on user input
            Console.WriteLine("The remainder of " + num5.ToString() + " when divided by 7 is " + numRemainder.ToString());  // Converting variables back to strings and displaying concatenated string to user

            Console.ReadLine(); // Pauses the program until user input

        }
    }
}
