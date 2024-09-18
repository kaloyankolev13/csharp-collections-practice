using System.Globalization;
using System.Net;
using System.Security.Cryptography;

namespace ListsApp
{
    internal class Program

    {
        public interface IAnimal
        {
            void MakeSound();
            void Eat(string food);
        }

        public class Dog : IAnimal
        {
            public void Eat(string food)
            {
                Console.WriteLine("Dog ate" + food);
            }

            public void MakeSound()
            {
                Console.WriteLine("Dog bark");
            }
        }

        public class Cat : IAnimal
        {
            public void Eat(string food)
            {
                Console.WriteLine("Cat ate" + food);
            }

            public void MakeSound()
            {
                Console.WriteLine("Cat meow");
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("Treat");

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat("fish");

            Console.ReadKey();
        }

    }
}
