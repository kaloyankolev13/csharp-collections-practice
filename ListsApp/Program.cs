using System.Globalization;

namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            Collie collie = new Collie();
            Cat cat = new Cat();

            dog.MakeSound();
            cat.MakeSound();

            Console.ReadKey();

        }

        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }

            public virtual void MakeSound()
            {
                Console.WriteLine("Generic sound");
            }
        }

        class Dog: Animal
        {
            public override void MakeSound()
            {
                base.MakeSound();
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

        class Cat: Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meowing");
            }
        }

    }
}
