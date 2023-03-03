using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                DateTime currentYear = DateTime.Today;
                int birthYear = currentYear.Year - age;
                Console.WriteLine("Your birth year is {0}", birthYear.ToString());
                Console.Read();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            finally { Console.Read(); }
        }
    }
}
