using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_AND_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try // Addiing a try method to do the code below and catch errors if one arises
            {
                List<int> nums = new List<int>() { 10, 12, 14, 16, 18 }; // Created a list of integers

                Console.WriteLine("Please enter a number to divide each list number by:"); // Asking user for input
                int divNum = Convert.ToInt32(Console.ReadLine()); // // Converting user input to integer

                foreach (int num in nums) // Iterating through list
                {
                    int result = num / divNum; // dividing each integer in list by user input
                    Console.WriteLine(num + " divided by " + divNum + " equals " + result); // Displaying result to console
                }
            }
            catch(FormatException ex) // Catching the FormatException error
            { 
                Console.WriteLine(ex.Message + " Please type a whole number"); // Displaying message on console if error happens
            }
            catch(DivideByZeroException ex) // Catching the FormatException error
            {
                Console.WriteLine(ex.Message + " Please do not divide by 0."); // Displaying message on console if error happens
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution."); // Displaying message on the console after the try/ catch execution 
            }

            Console.Read();
        }
    }
}
