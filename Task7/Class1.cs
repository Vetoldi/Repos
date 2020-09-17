using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    class Employee
    {
        string name;
        string surname;
        DateTime dateOfHire;
        double salary;

        public enum Position
        {
            Jun = 10000,
            Mid = 100000,
            Senior = 1000000
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                if (dateOfHire.Date < DateTime.Parse("01.01.1995"))
                {
                    dateOfHire = value;
                }
                else
                {
                    Console.WriteLine("Date before times!");
                }

            }
        }

        public Employee(string name, string surname, DateTime dateOfHire)
        {
            Name = name;
            Surname = surname;
            DateOfHire = dateOfHire;
        }

        public double DiscoverGrade(DateTime dateOfHire)
        
        {
            double dateValueForGrade = (DateTime.Now - dateOfHire).TotalDays;

            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
                return 1.5;
            else if (dateValueForGrade >= 3650)
                return 1.25;
            else
                return 1.0;
        }

        public double Calculation(Position position)
        
        {
            double grade = DiscoverGrade(dateOfHire);
            switch (position)
            {
                case Position.Jun:
                    salary = 10000 * grade;
                    return salary;
                case Position.Mid:
                    salary = 100000 * grade;
                    return salary;
                case Position.Senior:
                    salary = 1000000 * grade;
                    return salary;
                default:
                    Console.WriteLine("No such position!");
                    break;

            }
            return 0.0;
        }
    }
}
