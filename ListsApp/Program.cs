namespace ListsApp
{


        class Employee 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {



            Dictionary<int , Employee> employess = new Dictionary<int , Employee>();

            employess.Add(1, new Employee("John Doe", 20, 100000));
            employess.Add(2, new Employee("Hane Doe", 45, 120000));
            employess.Add(3, new Employee("Jane Smith", 31, 83000));
            employess.Add(4, new Employee("Bay Mangal", 18, 50000));

            foreach (var employee in employess)
            {
                Console.WriteLine($"ID: {employee.Key}, Named: {employee.Value.Name}, Aged: {employee.Value.Age}, Paid: {employee.Value.Salary}");
            }


            Console.ReadKey();
        }
    }
}
