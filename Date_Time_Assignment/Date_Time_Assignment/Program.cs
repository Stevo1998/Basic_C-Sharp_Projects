using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;

namespace Date_Time_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now; // Creating a DateTime variable with the nurrent date and time
            Console.WriteLine("The current date and time is: " + timeNow.ToString()); // Writes to the console the current date and time

            Console.WriteLine("Enter a number:"); // Asking user for input
            double userNum = Convert.ToDouble(Console.ReadLine()); // Storing user input in a double variable

            DateTime addHours = DateTime.Now.AddHours(userNum); // Adding user input to the hours of current time

            TimeSpan timeLater = addHours.TimeOfDay; // Setting a TimeSpan variable equal to time equal to the current time plus the added hours  

            Console.WriteLine("The time in {0} hour/hours will be: {1}", userNum.ToString(), timeLater.ToString()); // Displaying the time it will be after user input is added to the time as hours

            Console.Read(); // Pausing the application until user input.
        }
    }
}
