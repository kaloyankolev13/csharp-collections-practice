using System.Globalization;
using System.Net;
using System.Security.Cryptography;

namespace ListsApp
{
    internal class Program

    {
        public class Person
        {

            private string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Person constructor called");
            }

            public void DisplayPersonInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
            /// <summary>Makes our object older.</summary>
            /// <param name="years">The parameter that indicates the amount of years that the objects should age.</param>
            /// <returns>Return the new age after becoming older.</returns>
            public int BecomeOlder(int years)
            {
                Age += years;
                return Age;
            }
        }

        public class  Employee:Person
        {
            public string JobTitle { get; set; }
            public int EmloyeedID { get; set; }
            public Employee(string name, int age, string jobTitle, int emloyeedID) : base(name, age)
            {
                Console.WriteLine("Employee constructor called: derived");
                JobTitle = jobTitle;
                EmloyeedID = emloyeedID;
            }

            public void DisplayEmployeeInfo()
            {
                DisplayPersonInfo();
                Console.WriteLine($"Job title: {JobTitle}, EmployeeID: {EmloyeedID}");
            }
        }

        public class Manager : Employee
        {
            public int TeamSize {  get; private set; }
            public Manager(string name, int age, string jobTitle, int emloyeedID, int teamSize) : base(name, age, jobTitle, emloyeedID)
            {
                TeamSize = teamSize;
            }
            public void DisplayManagerInfo()
            {
                DisplayEmployeeInfo();
                Console.WriteLine($"TeamSize: {TeamSize}");
            }
        }


        static void Main(string[] args)
        {
            //Employee joe = new Employee("Joe", 35,"Banker", 12421);
            //joe.DisplayEmployeeInfo();
            Manager carl = new Manager("Carl", 50, "Manager", 30000, 7);
            carl.BecomeOlder(5);
            carl.DisplayManagerInfo();
            //carl.ToString();
            Console.ReadKey();

        }

    }
}
