using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            string userInput = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Steven Salazar\OneDrive\Escritorio\Basic_C#_Programs\Logs\log2.txt", userInput);

            Console.WriteLine(File.ReadAllText(@"C:\Users\Steven Salazar\OneDrive\Escritorio\Basic_C#_Programs\Logs\log2.txt"));

            Console.Read();
        }
    }
}
