using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Instatiating an object of the class employee
            employee.firstName = "Sample"; // Creating an object of employee
            employee.lastName = "Student"; // Creating an object of emplyee

            employee.SayName(); // Calling the superclass method SayName() to display both objects created on the console

            Console.Read();
        }
    }
}
