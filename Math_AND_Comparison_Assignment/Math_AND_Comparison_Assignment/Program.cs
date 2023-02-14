using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_AND_Comparison_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison ProgramAnonymous Income Comparison Program"); // Displaying string to user on console
            

            Console.WriteLine("\nPerson 1"); // Displaying string to user on console
            Console.WriteLine("Please enter your hourly rate:"); // Asking user for input
            double rate1 = Convert.ToDouble(Console.ReadLine()); // Converting user input into double datatype variable
            Console.WriteLine("Please enter your hours worked weekly:"); // Asking user for input
            double hours1 = Convert.ToDouble(Console.ReadLine()); // Converting user input into double datatype variable


            Console.WriteLine("\nPerson 2:"); // Displaying string to user on console
            Console.WriteLine("Please enter your hourly rate:"); // Asking user for input
            double rate2 = Convert.ToDouble(Console.ReadLine());  // Converting user input into double datatype variable
            Console.WriteLine("Please enter your hours worked weekly:"); // Asking user for input
            double hours2 = Convert.ToDouble(Console.ReadLine()); // Converting user input into double datatype variable


            double yearWeeks = 52.143; // Storing the number of weeks in a year into a double data type variable


            double weekPay1 = rate1 * hours1; // Performing math operation on Person 1 variables to get the weekly salary
            double annualPay1 = weekPay1 * yearWeeks; // Performing math operation on the total weekly salary of person 1 to estimate the annual salary
            double weekpay2 = rate2 * hours2; // Performing math operation on Person 2 variables to get the weekly salary
            double annualPay2 = weekpay2 * yearWeeks; // Performing math operation on the total weekly salary of person 2 to estimate the annual salary
            Console.WriteLine("\nAnnual salary of Person 1: " + annualPay1.ToString()); // Displaying the annual salary of person 1 to the user
            Console.WriteLine("Annual salary of Person 2: " + annualPay2.ToString()); // Displaying the annual salary of person 2 to the user

            bool trueOrFalse = annualPay1 > annualPay2; // Performing a boolean comparison between the anual salary of person 1 to person 2
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?\n" + trueOrFalse.ToString()); // Displaying a question to the user along with an answer

            Console.ReadLine();
        }
    }
}
