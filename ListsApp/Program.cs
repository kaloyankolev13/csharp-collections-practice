namespace ListsApp
{
    internal class Program
    {

        public class Product
        {

        }

        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 10,5,15,3,9,25,18};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            bool hasLargeNumber = numbers.Any(x => x > 20);

            if(hasLargeNumber)
            {
                Console.WriteLine("There are large numbers");
            }else
            {
                Console.WriteLine("No large numbers");
            }

            //Predicate<int> isGreaterThanten = x => x > 10;

            //List<int> higherTen = numbers.FindAll(isGreaterThanten);
            //foreach (int i in higherTen)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();
        }
    }
}
