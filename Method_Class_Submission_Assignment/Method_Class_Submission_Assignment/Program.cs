using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Submission_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math number1 = new Math(); // Creating an object number1 of the class Math
            number1.num1 = 5; // Instantiating an object of number1 to 5
            Math number2 = new Math(); // Creating an object number2 of the class Math
            number2.num2 = 10; // Instantiating an object of userNum1 to 10

            Math.addMethod(number1.num1,number2.num2);  // Calling the addMethod passing in two parameters

            Math.addMethod(num1: number1.num1, num2: number2.num2); // Calling the addMethod passing in two parameters by specified by name

            Console.Read(); // Pausing the application until user input
        }
    }

    public class Math // Creating a class
    {
        public int num1 { get; set; } // Creating an integer property
        public int num2 { get; set; } // Creating an integer property
        public static void addMethod(int num1, int num2) // Crating a void method to print two lines on the console
        {
            int resultNum1 = (num1 + 4); // Applying a math operation on num1
            Console.WriteLine(resultNum1); // Printing the result of num1 after math operation to the console
            Console.WriteLine(num2); // // Displaying num2 to the console
        }
    }
}
