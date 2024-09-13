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
            
            Console.WriteLine("Current colours");
            foreach (string colour in colours)
            {
                Console.WriteLine(colour);
            }
            Console.ReadKey();
        }
    }
}
