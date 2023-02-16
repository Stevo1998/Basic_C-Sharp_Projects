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

        if (message < 0 || message > stringArray.Length - 1) // If user input is less than 0 more than the length of the array, then...
        {
            Console.WriteLine("The number entered was not from 0 to 4."); // Display the string on the console
        }
        else // if user input meets a number in the array index, then...
        {
            Console.WriteLine("Message: " + stringArray[message]); // Display the string in the array at the index of user input
        }

        int[] numArray = { 0, 1, 4, 9, 16 }; // Creating an integer array
        Console.WriteLine("\nEnter a number from 0 to 4 to display a square number."); // Asking user for input
        int number = Convert.ToInt32(Console.ReadLine()); // Converting user input into an integer

        if (number < 0 || number > numArray.Length - 1 ) // If user input is less than 0 more than the length of the array, then...
        {
            Console.WriteLine("The number entered was not from 0 to 4."); // Display string on the console
        }
        else // if user input meets an index number in the array, then...
        {
            Console.WriteLine("Square number: " + numArray[number]); // Display the interger in the array at the index of user input
        }

        List<string> stringList = new List<string>(); // Creating a list of strings
        stringList.Add("How are you doing?"); // Adding a string to index 0
        stringList.Add("How are you?"); // Adding a string to index 1
        stringList.Add("How has it been?"); // Adding a string to index 2
        Console.WriteLine("\nEnter a number from 0 to 2 to display a question"); // Asking user for input
        int question = Convert.ToInt32(Console.ReadLine()); // Converting user input into an integer

        if (question < 0 || question > stringList.Count - 1) // If user input is less than 0 or more than the lenth of the list, then...
        {
            Console.WriteLine("The number entered was not from 0 to 2"); // Display string to the console
            
        }
        else // If user input meets an index number in the list, then... 
        {
            Console.WriteLine("Question: " + stringList[question]); // Display the string in the list at the index of user input
        }
        Console.Read(); // Pausing the apllication until user input
    }
 
}
