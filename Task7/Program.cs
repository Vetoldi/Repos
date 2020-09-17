using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee("Boris", "Voloshin", DateTime.Parse("22.08.2002"));
            Console.WriteLine("Name is {0}, surname is {1}. Date of hire: {2}", one.Name, one.Surname, one.DateOfHire);
            double salary = one.Calculation(Employee.Position.Senior);
            Console.WriteLine("Salary is {0}, tax is {1}, position is {2}.", salary, salary * 0.34, Employee.Position.Senior);
        }
    }
}   
