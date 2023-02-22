using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number num1; // Declaring an object called num1 of the type Number
            num1.Amount = 10.59m; // Defying an amount property of the num1 object

            Console.WriteLine(num1.Amount); // Displaying the amount property of num1 to the console
            Console.Read(); // Pausing the application until user input
        }
    }

    struct Number // Creating a struct called Number
    {
        public decimal Amount; // Giving the struct Number a property Amount of decimal datatype
    }
}
