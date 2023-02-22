using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); // Instatiating a new object of Employee type as employee1
            employee1.Id = 0; // Creating an Id object of employee1
            employee1.firstName = "Sample1"; // Creating a object of employee1
            employee1.lastName = "Employee"; // Creating a object of employee1

            Employee employee2 = new Employee(); // Instatiating a new object of Employee type as employee2
            employee2.Id = 1; // Creating an Id object of employee2
            employee2.firstName = "Sample2"; // Creating a firstName object of employee2
            employee2.lastName = "Sample2"; // Creating a lastName object of employee2


            Console.WriteLine(employee1 == employee2); // Displaying result of overloaded operator to the console
            Console.WriteLine(employee1 != employee2); // Displaying result of overloaded operator to the console

            Console.Read();
        }
    }
}
