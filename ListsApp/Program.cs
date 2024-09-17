using System.Globalization;

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
                Console.WriteLine($"Job title: {JobTitle}, EmployeeID {EmloyeedID}");
            }
        }


        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe", 35,"Banker", 12421);
            joe.DisplayEmployeeInfo();
            Console.ReadKey();

        }

    }
}
