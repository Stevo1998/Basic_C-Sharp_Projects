using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    public class Person // Creating a public class
    {
        public string firstName { get; set; } // Creating a string  property of person
        public string lastName { get; set; } // Creating a string property of pperson

        public void SayName() // Creating a public void method that displays the two properties created on the console
        {
            Console.WriteLine(firstName+ " " + lastName);
        }
    }
}
