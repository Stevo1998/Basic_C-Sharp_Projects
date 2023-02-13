using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy."); // Displaying string to the console
            Console.WriteLine("Student Daily Report."); // Displaying string to the console

            Console.WriteLine("\nWhat is your name?"); // Asking user for input
            string studentName = Console.ReadLine(); // Assigning output to a string data type variable

            Console.WriteLine("\nWhat coourse are you on?"); // Asking user for input
            string courseName = Console.ReadLine();

            Console.WriteLine("\nWhat page number?"); // Asking user for input
            int pageNumber = Convert.ToInt32(Console.ReadLine()); // Converting string output to assign to integer data type variable

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\"."); // Asking user for input
            bool needHelp = Convert.ToBoolean(Console.ReadLine()); // Converting string output to assign to boolean data type variable

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics."); // Asking user for input
            string positiveXp = Console.ReadLine(); // Assigning output to a string data type variable

            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific."); // Asking user for input
            string feedBack = Console.ReadLine(); // Assigning output to a string data type variable

            Console.WriteLine("\nHow many  hours did you study today?"); // Asking user for input
            int studyHours = Convert.ToInt32(Console.ReadLine()); // Converting string output to assign to assign to integer data type variable


            Console.WriteLine("\nThank you for your answers. An instructor will respond to this shortly. Have a great Day!"); // Displaying string to the console
            Console.ReadLine(); // Pauses the program until user input 
        }
    }
}
