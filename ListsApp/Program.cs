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

            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "Cali",
                ["TX"] = "Texas",
            };

            if(codes.TryGetValue("NY", out string state))
            {
                Console.WriteLine(state);
            }

            foreach(var item in codes)
            {
                Console.WriteLine($"The state code is {item.Key} and the state is {item.Value}");
            }


            Console.ReadKey();
        }
    }
}
