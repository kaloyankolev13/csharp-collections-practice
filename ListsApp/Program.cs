using System.Globalization;

namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            Collie collie = new Collie();
            dog.Bark();
            dog.Eat();
            collie.Bark();
            collie.GoingNuts();
            Console.ReadKey();

        }

        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }

        class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("Meowing");
            }
        }

        class Dog: Animal
        {
            public void Bark()
            {
                Console.WriteLine("Barking");
            }
        }

        class Collie: Dog
        {
            public void GoingNuts()
            {
                Console.WriteLine("Going Nuts");
            }
        }



    }
}
