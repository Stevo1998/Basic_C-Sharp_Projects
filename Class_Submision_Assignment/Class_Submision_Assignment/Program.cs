using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submision_Assignment
{
    static class Program // Declaring static class
    {
        static void Main(string[] args)
        {
            Math userNum = new Math(); // // Creating an object number1 of the class Math
            Console.WriteLine("Enter a number:"); // Asking user for input
            userNum.number = Convert.ToInt32(Console.ReadLine()); // Instantiating an object of userNum to user input
            int addedNum = userNum.number; // Cerating an int variable equal to user 
            Math num = new Math();  // Creating an object number2 of the class Math
            num.number2 = 1; // Instantiating an object of num to 1

            Math.Divide(userNum.number); // Calling the Divide() method with one parameter
            Math.Mult(userNum.number, out addedNum); // Calling the Mult() method with an out parameter
            Math.Divide(userNum.number, num.number2); // Calling the Divide() method with two parameters


            Console.ReadLine();

        }
    }
    public class Math // Declaring pulic class
    {
        public int number { get; set; } // Creating an integer property
        public int number2 { get; set; } // Creating an integer property
        public static void Divide(int number) // Creating a void method
        {
            Console.WriteLine("Your number divided by 2 = " + number / 2); // Displaying the Divide() method results on console
        }
        
        public static void Mult(int number, out int addedNum) // Creating a void method with an out parameter
        {
            addedNum = number; // Setting the out parameter equal to the number property
            Console.WriteLine("Your number multiplied by itself = " + number * number); // Displaying the Mult() method result on console
            Console.WriteLine("Number entered: {0}", addedNum); // Displaying out parameter on console
        }

        public static void Divide(int number, int number2) // Overloading the Divide() method
        {
            Console.WriteLine("Your number divided by " + number2 + " = " + number / number2); // Displaying the overloaded Divide() method results on Console
        }

    }
}
