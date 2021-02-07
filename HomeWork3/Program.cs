using System;
using ClassLibrary1;

namespace HomeWork3
{       
    class Program 
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.GetInfo();

            Circle circle1 = new Circle(15);
            circle.GetInfo();

            Square square = new Square();
            square.GetInfo();

            Rectangle rectangle = new Rectangle();
            rectangle.GetInfo();

            Triangle triangle = new Triangle();
            triangle.GetInfo();

            Console.WriteLine(Circle.GetPerimeter(56));
            Console.WriteLine(Circle.GetArea(56));

            Console.WriteLine(Square.GetPerimeter(15));
            Console.WriteLine(Square.GetArea(15));

            Console.WriteLine(Rectangle.GetPerimeter(15, 25));
            Console.WriteLine(Rectangle.GetArea(15, 25));

            Console.WriteLine(Triangle.GetPerimeter(15, 25, 35));
            Console.WriteLine(Triangle.GetArea(15, 25));
        }
    }
}
