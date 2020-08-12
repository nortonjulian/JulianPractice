using System;
using System.Collections.Generic;

namespace JulianPractice
{
    class Program
    {
        static void Main(string[] args)
        {            
            //This is your instance of the company
            Company c = new Company();

            //This is your numbers array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
           

            //You should not be adding anything to the classes I have made
            //You do not need to make any new classes
            //You do not need a new instance of Company
            //You do not need to make a new array
            //You do not need to make a new List

            //In this project there are 2 classes Employee and Company. Look at those classes and see what they contain.
            //There is also an array of numbers called numbers. You'll be using that for the array part of this.


            //Use a loop to print all the numbers in the numbers array.


            //Use a loop to print out only the odd numbers in the numbers array


            //Use a loop to print out every other number in the numbers array


            //Set the company's list of employee = to the PopulateEmployees() method


            //Create 3 new employees and set their properties. You may find use of the parameterized constructor.


            //Add your new employees to the employee list in the company.


            //Use a loop to print out every employee's full name that is in the company's list of employees.
        }

        //DO NOT TOUCH THIS//
        private static List<Employee> PopulateEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee("Cruz","Sanchez",27),
                new Employee("John", "Ward", 36),
                new Employee("Michael","Doyle",33),
                new Employee("Whit","Stroup",34),
                new Employee("Tanner","Riddle",20),
                new Employee("Dan","Walsh",27),
                new Employee("Nathan","Rice",27),
                new Employee("Ben","Bryant",24),
                new Employee("Big","Boss",36),
                new Employee("Solid","Snake",30)
            };

            return employees;
        }
    }
}
