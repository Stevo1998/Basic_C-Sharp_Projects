using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below."); // Displaying welcome string to the user on the console

            Console.WriteLine("\nPlease enter the package weight:"); // Asking user for input on the console
            double packageWeight = Convert.ToDouble(Console.ReadLine()); // Converting user input and saving into a double data type variable

            if (packageWeight > 50) // Using an if statement to check if user input is greater than 50
            {
                Console.WriteLine("Package too heavy to be shippped via Package Express. Have a good day."); // If then if statement is true then display string on console
            }
            else                                                                                             // Else move on to code below
            {
                Console.WriteLine("\nPlase enter the package width:"); // Asking user for input on the console
                double packageWidth = Convert.ToDouble(Console.ReadLine()); // Converting user input and saving into a double data type variable

                Console.WriteLine("\nPlease enter the package height:"); // Asking user for input on the console
                double packageHeight = Convert.ToDouble(Console.ReadLine()); // Converting user input and saving into a double data type variable

                Console.WriteLine("\nPlase enter the package length:"); // Asking user for input on the console
                double packageLength = Convert.ToDouble(Console.ReadLine()); // Converting user input and saving into a double data type variable

                double quoteResult = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100.00; // Using math operators on saved variables  to estimate the user's quote

                if ((packageWidth + packageHeight + packageLength) > 50) // Using an if statement to check if the package's  dimensions exceed 50 when added together
                {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express."); // If the "if" statement is true then display string on the console 
                }
                else                                                                           // Else move on to code below
                {
                    Console.WriteLine("\nYour estimated total for shipping this package is: $" + quoteResult.ToString() + "\nThank you!"); // Displaying quote string to the user on the console
                }
            }
            Console.ReadLine(); // Pausing the application until user input
        }
    }
}
