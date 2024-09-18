using System.Globalization;
using System.Net;
using System.Security.Cryptography;

namespace ListsApp
{
    internal class Program
    {
        public interface IShape
        {
            double GetArea();
        }

        public class Circle : IShape
        {
            private double _radius;

            public Circle(float radius)
            {
                _radius = radius;
            }

            public double GetArea()
            {
                return Math.PI * _radius * _radius;
            }
        }

        public class Rectangle : IShape
        {
            private double _height;
            private double _width;

            public Rectangle(double height, double width)
            {
                _height = height;
                _width = width;
            }

            public double GetArea()
            {
                return _height * _width;
            }
        }


        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[] 
            { 
                new Circle(5),
                new Rectangle(4, 6),
            };

            foreach (IShape shape in shapes) 
            {
                if (shape is Circle)
                {
                    Console.WriteLine($"Area: {shape.GetArea():F2}");
                }
                else if (shape is Rectangle) 
                {
                    Console.WriteLine($"Area: {shape.GetArea():F2}");
                }
            }

            Console.ReadKey();
        }
    }
}
