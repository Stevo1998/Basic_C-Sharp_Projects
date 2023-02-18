using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1 
            string[] greetings = { "Hello", "Hi", "Hey", "Howdy" }; // Defying a one-dimensional array of strings

            Console.WriteLine("Please enter your name:"); // Asking the user to input text
            string userText = Console.ReadLine(); // Saving user input on a string variable

            for (int i = 0; i < greetings.Length; i++) // Iterating through each string in the array
            {
                string greetingUser = greetings[i] + ", " + userText; // Appending user input to each string

                if (i <= greetings.Length) // Applying an if conditon to the for loop
                {
                    Console.WriteLine(greetingUser); // Displaying each string with appended user input as the for loop iterates through the array
                }
            }

            // Assignment Part 2
            int integer = 1; // Assigning an interger variable the value of 1
            bool j = true; // Assigning the bool variable a value of true

            while (j) // Creating an infinite loop
            {
                Console.WriteLine(integer.ToString()); // Displaying the number variable on the console
                integer++; // Adding 1 to the value of number

                if (integer == 11) // Adding an if condition to fix the infite loop
                {
                    j = false; // if the value of number reaches 11 change the value of j to false
                }
            }


            // Assignment Part 3
            List<int> nums = new List<int>() { 11, 12, 13, 14, 15 }; // Crating a list of integers
            foreach (int num in nums) // Adding a loop to iterate through list
            {
                if ( num < 13 ) // Using a less than comparison to stop iterion
                {
                    Console.WriteLine(num);
                    break;
                }
            }
            foreach (int num in nums)
            {
                if (num <= 12) // Using a less than or equal to  comparison to stop iteration
                {
                    Console.WriteLine(num);
                    break;
                }
            }

                ////Assignment Part 4
                List<string> carBrands = new List<string>() { "toyota", "nissan", "ford", "dodge", "chevrolet" }; // Defying a list of strings

            Console.WriteLine("\nEnter a car's make to view its index on the list:"); // Asking user for input text
            string userBrand = Console.ReadLine().ToLower(); // Storing  user input into string variable and coverting to lower case text

            if (carBrands.Contains(userBrand)) // if user input matches a string in list, then...
            {
                foreach (string brand in carBrands) // Iterating through the strings in list
                {
                    if (brand == userBrand)
                        Console.WriteLine("Index = " + carBrands.IndexOf(userBrand)); // Display string index on the console
                }
            }
            else
            {
                Console.WriteLine(userBrand + " is not on the list");
            }


            // Assignment 5
            List<string> numbers = new List<string>() { "1", "1", "2", "2", "3" }; // Defying a list of strings

            Console.WriteLine("\nEnter a number to view its index on the list:"); // Asking for user input
            string userNumber = Console.ReadLine(); // Saving user inout in a string data type variable

            for (int number = 0; number < numbers.Count; number++)  // Iterating through the list 
            {
                if (userNumber == numbers[number]) // If the user input matches a list item, then...
                {
                    Console.WriteLine("Index = " + number); // Display the item's index on the console
                }
            }
            if (!numbers.Contains(userNumber)) // If the user input does not match a list item, then...
            {
                Console.WriteLine(userNumber + " is not on the list."); // Display string to the console
            }

            // Assignment 6
            List<string> letters = new List<string>() { "A", "B", "C", "D", "C" }; // Defying a list of strings
            List<string> dups = new List<string>();


            foreach (string letter in letters) // Iterating through each string in list
            {
                if (dups.Contains(letter))
                {
                    Console.WriteLine(letter + " - this item is duplicated");
                }
                else
                {
                    Console.WriteLine(letter + " - this item is unique");
                }
                dups.Add(letter);
            }


            Console.Read(); // Pausing the application until  user input
        }
    }
}
