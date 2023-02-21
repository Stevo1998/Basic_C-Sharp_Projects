using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public abstract class Person // Creating a public abstract class called Person
    {
        public string firstName { get; set; } // Giving the Person class a string property called firstNamme
        public string lastName { get; set; } // Giving the Person class a string property called lastName

        public abstract void SayName(); // Giving the Person class an abstract method called SayName()
    }
}
