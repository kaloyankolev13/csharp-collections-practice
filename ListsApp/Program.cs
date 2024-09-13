namespace ListsApp
{
    internal class Program
    {

        public class Product
        {
           public string Name { get; set; } 
            public double Price { get; set; }
        }

        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
            {
                new Product { Name = "Bananas", Price = 3.99 },
                new Product { Name = "Apples", Price = 1.99 } ,
                new Product { Name = "Pineapple", Price = 5.99 }

            };


            products.Add(new Product
            {
                Name = "Berries",
                Price = 2.99
            });


            List<Product> cheapProducts = products.Where(p => p.Price < 3).ToList();

            Console.WriteLine("Available cheap products: ");

            foreach (Product p in cheapProducts) Console.WriteLine($"Product name: {p.Name}, Price: {p.Price}");



            Console.ReadKey();
        }
    }
}
