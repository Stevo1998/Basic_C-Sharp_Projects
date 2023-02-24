using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string greeting = "Hello"; // Creating a const variable
            var user1 = new User("Steven"); // Creating a var variable (User) to instantiate a new object of type User with the name of Steven 
            Console.WriteLine(greeting); // Displaying the const variable on the console
            Console.WriteLine(user1.Name + user1.Id); // Displaying the user name and Id number on the console
            Console.Read();
        }
    }
    internal class User // Creating a class called User
    {
        public User(string Name) : this(Name, 1) // Creating a constructor that takes one parameter as name and assigns a default value to Id
        {

        }

        public User(string Name, int Id) // Creating a constructor that inherits from the previous constructor on the Id value
        {
            this.Name = Name;
            this.Id = Id;
        }
        public string Name { get; set; } // Creating an user string property of name 
        public int Id { get; set; } // Creating an interger property of Id
    }
}
