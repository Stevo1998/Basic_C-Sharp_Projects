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
            Console.WriteLine("This is how you count from zero to five in Spanish:");
            int numero = 0;

            do
            {
                Console.WriteLine("Cero");
                numero++;

                Console.WriteLine("Uno");
                numero++;

                Console.WriteLine("Dos");
                numero++;

                Console.WriteLine("Tres");
                numero++;

                Console.WriteLine("Cuatro");
                numero++;

                Console.WriteLine("Cinco");
                numero++;
            }
            while (numero < 6);

            Console.WriteLine("\nThis how how you count from zero to five in English:");
            int number = 0;

            while (number < 6)
            {
                Console.WriteLine("Zero");
                number++;

                Console.WriteLine("One");
                number++;

                Console.WriteLine("Two");
                number++;

                Console.WriteLine("Three");
                number++;

                Console.WriteLine("Four");
                number++;

                Console.WriteLine("Five");
                number++;
            }

            Console.Read();
        }
    }
}
