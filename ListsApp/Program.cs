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
            public Employee(string name, int age) : base(name,age)
            {
                Console.WriteLine("Employee constructor called: derived");
            }
        }


        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe", 35);
            joe.DisplayPersonInfo();
            Console.ReadKey();

        }

    }
}
