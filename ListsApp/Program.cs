using System.Globalization;

namespace ListsApp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Student> students = new Dictionary<string, Student>
            {
                ["John"] = new Student(1, "John", 85),
                ["Alice"] = new Student(2, "Alice", 90),
                ["Bob"] = new Student(3, "Bob", 78),
            };

            foreach (var student in students) {
                Console.WriteLine($"Name: {student.Value.Name}, Id: {student.Value.Id}, Grade: {student.Value.Grade}");
            }
        }

    }
}
