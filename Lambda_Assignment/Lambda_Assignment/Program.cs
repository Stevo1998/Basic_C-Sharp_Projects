using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instatiating new objects as well assigning value to their properties 
            Employee employee1 = new Employee();
            employee1.firstName = "Joe";
            employee1.lastName = "Smith";
            employee1.Id = 1;
            

            Employee employee2 = new Employee();
            employee2.firstName = "Carl";
            employee2.lastName = "Jones";
            employee2.Id = 2;

            Employee employee3 = new Employee();
            employee3.firstName = "Silvia";
            employee3.lastName = "Salas";
            employee3.Id = 3;

            Employee employee4 = new Employee();
            employee4.firstName = "Robert";
            employee4.lastName = "Titus";
            employee4.Id = 4;

            Employee employee5 = new Employee();
            employee5.firstName = "Alex";
            employee5.lastName = "Church";
            employee5.Id = 5;

            Employee employee6 = new Employee();
            employee6.firstName = "Petter";
            employee6.lastName = "Petterson";
            employee6.Id = 6;

            Employee employee7 = new Employee();
            employee7.firstName = "Joe";
            employee7.lastName = "Allen";
            employee7.Id = 7;

            Employee employee8 = new Employee();
            employee8.firstName = "Alice";
            employee8.lastName = "Cooper";
            employee8.Id = 8;

            Employee employee9 = new Employee();
            employee9.firstName = "Steven";
            employee9.lastName = "Stevenson";
            employee9.Id = 9;

            Employee employee10 = new Employee();
            employee10.firstName = "Leonel";
            employee10.lastName = "Galo";
            employee10.Id = 10;


            List<Employee> employeeList = new List<Employee>()  // Instatiating a List of the employees class and adding all objects created to it
            { 
                employee1, employee2, employee3, employee4, employee5, 
                employee6, employee7, employee8, employee9, employee10,
            };


            foreach (Employee employee in employeeList) // Using a foreach loop to create a new list of employees named Joe
            {
                List<Employee> joeList = new List<Employee>();
                if (employee.firstName == "Joe") 
                {
                    joeList.Add(employee);
                    Console.WriteLine(employee.firstName + " " + employee.lastName);
                }
            }

            List<Employee> joeLambdaList = employeeList.Where(x => x.firstName == "Joe").ToList(); // Using a Lamda expression to create a new list of employees named Joe
            foreach (Employee employee in joeLambdaList)
            {
                Console.WriteLine(employee.firstName);
            }

            List<Employee> idList = employeeList.Where(x => x.Id > 5).ToList(); // Using a Lamda expression to create a new list of employees whose id is greater than 5
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.firstName + " Id:" + employee.Id);
            }

            Console.ReadLine(); // Pausing the application until user input
        }
    }
}
