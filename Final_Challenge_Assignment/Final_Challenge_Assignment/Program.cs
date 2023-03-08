using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Challenge_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                string firstName = "Leonardo";
                string lastName = "Salazar";

                var student = new Student { firstName = firstName, lastName = lastName };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.Id
                            select s;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine("Id: {0}, First name: {1}, Last Name: {2}.", item.Id, item.firstName, item.lastName);
                    Console.Read();
                }
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
