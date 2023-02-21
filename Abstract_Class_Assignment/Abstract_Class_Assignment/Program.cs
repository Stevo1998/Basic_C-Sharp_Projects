using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Instantiating an object of the Employee class called employee
            employee.firstName = "Sample"; // Creating an object of employee with a firstName string
            employee.lastName = "Student"; // Creating an object of employee with a lastName string
            employee.SayName(); // Calling the SayName method on the employee object

            Console.Read();
        }
    }
}
