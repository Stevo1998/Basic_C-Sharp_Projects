using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math num = new Math(); // Creating object num of the class math
            num.integer = 5; // Instantiating an object if num
            int resultAdd = Math.addMethod(num.integer); // Calling the addMethod method passing in num.integer
            Console.WriteLine(resultAdd.ToString()); // Displaying method result on the console


            Math numDecimal = new Math(); // Creating an object numDecimal  of the class math
            numDecimal.integerDecimal = 5.3; // Instantiating an object if numDecimal
            int resultAddDecimal = Math.addMethod(numDecimal.integerDecimal); // Calling the addMethod method passing in numDecimal.integerDecimal
            Console.WriteLine(resultAddDecimal.ToString()); // Displaying method result on the console


            Math numString = new Math(); // Creating an object numString of the class math
            numString.integerString = "14"; // Instantiating an object if numString
            int resultAddString = Math.addMethod(numString.integerString); // Calling the addMethod method passing in numString.stringInteger
            Console.WriteLine(resultAddString.ToString()); // Displaying method result on the console


            Console.Read();  // Pausing app until user input
        }
    }
    public class Math 
    {
        public int integer { get; set; } // Crating an integer property
        public double integerDecimal { get; set; } // Creating a double property

        public string integerString { get; set; } // Creating a string property

        public static int addMethod(int integer) // Creting a method
        {
            return integer + 5; // Adding 5 to integer and returning math operation result
        }

        public static int addMethod(double integerDecimal) // Creating a method
        {
            return Convert.ToInt32(integerDecimal) + 10; // Converting integerDecimal to int datatype and adding 10 returning math operation result
        }

        public static int addMethod(string integerString) // Creating a method
        {
            int numResult = Convert.ToInt32(integerString) + 6; // Converting integerString to int datatype and adding 6
            return numResult; // Returning math operation result
        }
    }
}
