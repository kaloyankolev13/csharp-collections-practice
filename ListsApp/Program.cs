namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> colours = new List<string>();
            colours.Add("red");
            colours.Add("blue");
            colours.Add("green");
            colours.Add("red");
            
            Console.WriteLine("Current colours");
            foreach (string colour in colours)
            {
                Console.WriteLine(colour);
            }

            bool deleteSuccesful = colours.Remove("red");

            while (deleteSuccesful)
            {
                deleteSuccesful = colours.Remove("red");
            }

            Console.WriteLine("Current colours");
            foreach (string colour in colours)
            {
                Console.WriteLine(colour);
            }





            Console.ReadKey();
        }
    }
}
