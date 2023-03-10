using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public class Employee : Person, IQuittable// Creating a public class called employee that inherits from the Person class
    {
        public override void SayName() // Overiding the abstract method SayName() to display the content of the two properties in the Person class
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit(string first, string last)
        {
            Console.WriteLine(first + " " + last + " quit.");
        }
    }
}
