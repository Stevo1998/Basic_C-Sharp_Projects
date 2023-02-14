using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?"); // Asking user for inout on the console
            int age = Convert.ToInt32(Console.ReadLine()); // Saving user input and converting it to an integer data type

            Console.WriteLine("\nTrue or False: Have you ever had a DUI?"); // Asking user for input on the console
            bool dui = Convert.ToBoolean(Console.ReadLine()); // Saving user input and converting it to a boolean data type

            Console.WriteLine("\nHow many speeding tickets do you have?"); // Asking user for inout on the console
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); // Saving user input and converting it to an integer data type

            Console.WriteLine("\nQualified?"); // Displaying question string to the user on the console
            bool qualifies = (age > 15 && dui == false && speedingTickets <= 3); // Using boolean logic to determine user qualifications based on their input
            Console.WriteLine(qualifies); // Displaying answer string to the user on the console

            Console.ReadLine(); // Pauses the application until user input.
        }
    }
}
