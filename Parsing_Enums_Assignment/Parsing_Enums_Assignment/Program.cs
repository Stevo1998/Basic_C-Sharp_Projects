using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week:"); // Asking user for input

            try // Adding a try block
            {
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), UppercaseFirst(Console.ReadLine())); // Parsing enum to check for user input

                Console.WriteLine("The current day is: " + currentDay); // Displaying enum on console
            }
            catch (System.ArgumentException ex) // Catching argument execption where user input is not found in enum
            { 
                Console.WriteLine("Please enter an actual day of the week."); // Displaying string on cosole if error occurs
            }

            Console.Read(); // Pausing the application until user input
        }
        public enum DaysOfWeek // Defying variable of datatype enum
        {
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7,
            Sunday = 1
        }
        static string UppercaseFirst(string day) // Defying a static function to apply to user input
        {
            if (string.IsNullOrEmpty(day)) // If string is null return empty string
            {
                return string.Empty;
            }
            else // Else return first letter uppercase on string plus the rest of the string after the first letter
            {
                return char.ToUpper(day[0]) + day.Substring(1);
            }
        }
    }
}