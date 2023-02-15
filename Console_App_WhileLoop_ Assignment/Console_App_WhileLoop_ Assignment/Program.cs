using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_WhileLoop__Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is how you count from zero to five in Spanish:"); // Displaying string to the user on the console
            int numero = 0; // assinging an integer data type variable

            do
            {
                Console.WriteLine("Cero"); // Display string to console
                numero++; // add 1 to the numero variable

                Console.WriteLine("Uno"); // Display string to console
                numero++;  // add 1 to the numero variable

                Console.WriteLine("Dos"); // Display string to console
                numero++; // add 1 to the numero variable

                Console.WriteLine("Tres"); // Display string to console
                numero++; // add 1 to the numero variable

                Console.WriteLine("Cuatro"); // Display string to console
                numero++; // add 1 to the numero variable

                Console.WriteLine("Cinco"); // Display string to console
                numero++; // add 1 to the numero variable
            }
            while (numero < 6); // do the code above while the numero variable is less than 6

            Console.WriteLine("\nThis how how you count from zero to five in English:");
            int number = 0;

            while (number < 6) // dgo through the loop below while the number variable is less than 6
            {
                Console.WriteLine("Zero"); // Display string to console
                number++;  // add 1 to the number variable

                Console.WriteLine("One"); // Display string to console
                number++; // add 1 to the number variable

                Console.WriteLine("Two"); // Display string to console
                number++; // add 1 to the number variable

                Console.WriteLine("Three"); // Display string to console
                number++; // add 1 to the number variable

                Console.WriteLine("Four"); // Display string to console
                number++; // add 1 to the number variable

                Console.WriteLine("Five"); // Display string to console
                number++; // add 1 to the number variable
            }

            Console.Read(); // Pause application until user input
        }
    }
}
