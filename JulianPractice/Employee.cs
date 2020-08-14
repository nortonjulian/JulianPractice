using System;
using System.Collections.Generic;
using System.Text;

namespace JulianPractice
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Age { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

       



    }
}
