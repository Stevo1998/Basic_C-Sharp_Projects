using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:"); // Asking user for input 
            Math userNum = new Math(); // Crating an object of the class Math
            userNum.integer = Convert.ToInt32(Console.ReadLine()); // Assigning user input to the object of the class Math


            int resultAdd = Math.addMethod(userNum.integer); // Calling the addMethod from the Math Class
            int resultMultiply = Math.multiplyMethod(userNum.integer); // Calling the multiplyMethod from the Math class
            int resultDivide = Math.DivideMethod(userNum.integer); // Calling the divideMethod from the math class


            Console.WriteLine // Displaying math results from each method to the user
                ( 
                    "Your number plus 5 = " + resultAdd.ToString() +
                    "\nYour number multiplied by 5 = " + resultMultiply.ToString() + 
                    "\nYour number divided by 2 = " + resultDivide.ToString()
                );

            Console.Read(); // Pausing the app until user input
        }
    }
}
