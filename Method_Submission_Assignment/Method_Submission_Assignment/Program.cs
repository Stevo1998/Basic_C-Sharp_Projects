using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:"); // Asking user for input
            Math userNum1 = new Math(); // Creating an object userNum1 of the class Math
            userNum1.num1 = Convert.ToInt32(Console.ReadLine()); // Instantiating an object of userNum1 to user input

            try // Adding a try block
            {
                Console.WriteLine("Enter a second whole number:" + "\nNote: This can be left blank."); // Asking user for input
                Math userNum2 = new Math(); // Creating an object userNum2 of the class Math
                userNum2.num2 = Convert.ToInt32(Console.ReadLine()); // Instantiating an object of userNum2 to user input

                int result = Math.mathMethod(userNum1.num1, userNum2.num2); // Calling the mathMethod method with both parameters 

                Console.WriteLine("{0} + {1} = {2}", userNum1.num1.ToString(), userNum2.num2.ToString() ,result.ToString()); // Displaying method result to the console
            }
            catch (FormatException ex) // Catching FormatExecpption error, if user enters null value for second number
            {
                int result = Math.mathMethod(userNum1.num1); // Calling the mathMethod with only one parameter

                Console.WriteLine("{0} + None = {1}", userNum1.num1.ToString(), result.ToString()); // Displaying method result to the console
            }


            Console.Read(); // Pausing the application until user input
        }
    }
    public class Math // Creating a class
    {
        public int num1 { get; set; } // Creating an integer property
        public int num2 { get; set; } // Creating an integer property
        public static int mathMethod(int num1, int num2 = 0) // Creating a method with two parameters where one is optional
        {
            return num1 + num2; // Returning the result of both parameter added together
        }
    }
}
