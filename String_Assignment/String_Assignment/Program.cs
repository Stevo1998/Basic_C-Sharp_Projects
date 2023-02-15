using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello,".ToUpper(); // Creating a string variable
            string name = "My name is Leonardo."; // Creating a string variable
            string comment = "Nice to meet you!"; // Creating a string variable

            StringBuilder sb = new StringBuilder(); // Creating a StringBuilder
            sb.Append(greeting + "\n" + name + "\n" + comment); // Appeding the created string variables to the stringbuilder

            Console.WriteLine(sb); // Displaying the string created on the StringBuilder variable to the console
            Console.Read(); // Pauses the application until user input.

        }
    }
}
