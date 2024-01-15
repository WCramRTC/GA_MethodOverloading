using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading
{
    public class EmployeeDatabase
    {
        // Overloaded method to add an employee with just a name
        public void AddEmployee(string name)
        {
            // Add employee to the database with name only
            Console.WriteLine($"Added employee: {name}");
        }

        // Overloaded method to add an employee with name and age
        public void AddEmployee(string name, int age)
        {
            // Add employee to the database with name and age
            Console.WriteLine($"Added employee: {name}, Age: {age}");
        }

        // Overloaded method to add an employee with name, age, and department
        public void AddEmployee(string name, int age, string department)
        {
            // Add employee to the database with name, age, and department
            Console.WriteLine($"Added employee: {name}, Age: {age}, Department: {department}");
        }
    } // class

} // namespace
