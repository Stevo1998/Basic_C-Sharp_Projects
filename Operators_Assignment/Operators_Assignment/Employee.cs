using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public class Employee // Defining a public class called Employee
    {
        public int Id { get; set; } // Defining an integer property
        public string firstName { get; set; } // Defining a string property
        public string lastName { get; set; } // Defining a string property

        public static bool operator ==(Employee employee1, Employee employee2) // Overloading the == operator
        {
            if (employee1.Id == employee2.Id) // If the id properties of the objects are the same return true else return false
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee employee1, Employee employee2) // Overloading the != operator
        {
            if (employee1.Id != employee2.Id) // If the id properties of the objects are not the same return true else return false
                return true;
            else
                return false;
        }
    }
}
