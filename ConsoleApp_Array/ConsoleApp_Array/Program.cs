using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

internal class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = { "Hello", "Hi", "Howdy", "Greetings", "Hey" }; // Creating a string array with 5 strings
        Console.WriteLine("Enter a number from 0 to 4 to display a message."); // Asking user for input
        int message = Convert.ToInt32(Console.ReadLine()); // Converting user input to integer 

        if (message <= 4) // if user input is less than or queal to 4, then...
        {
            Console.WriteLine("Message: " + stringArray[message]); // Display the string in the array at the index of user input
        }
        else // if user input is more than 4, then...
        {
            Console.WriteLine("The number entered was not from 0 to 4."); // Display the string on the console
        }

        int[] numArray = { 0, 1, 4, 9, 16 }; // Creating an integer array
        Console.WriteLine("\nEnter a number from 0 to 4 to display a square number."); // Asking user for input
        int number = Convert.ToInt32(Console.ReadLine()); // Converting user input into an integer

        if (number <= 4) // If user input is less than or queal to 4, then...
        {
            Console.WriteLine("Square number: " + numArray[number]); // Display the interger in the array at the index of user input
        }
        else // if user input is more than 4, then..
        {
            Console.WriteLine("The number entered was not from 0 to 4."); // Display string on the console
        }

        List<string> stringList = new List<string>(); // Creating a list of strings
        stringList.Add("How are you doing?"); // Adding a string to index 0
        stringList.Add("How are you?"); // Adding a string to index 1
        stringList.Add("How has it been?"); // Adding a string to index 2
        Console.WriteLine("\nEnter a number from 0 to 2 to display a question"); // Asking user for input
        int question = Convert.ToInt32(Console.ReadLine()); // Converting user input into an integer

        if (question <= 2) // If user input is less than or equal to 2, then...
        {
            Console.WriteLine("Question: " + stringList[question]); // Display the string in the list at the index of user input
        }
        else // If user input is more than 2, then...
        {
            Console.WriteLine("The number entered was not from 0 to 2"); // Display string to the console
        }
        Console.Read(); // Pausing the apllication until user input
    }
 
}
