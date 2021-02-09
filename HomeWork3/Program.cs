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

            Circle circle1 = new Circle(16);

            Console.WriteLine(circle.GetFigurePerimeter());
            Console.WriteLine(circle.GetFigureArea());

            Square square = new Square();
            square.GetInfo();

            Square square1 = new Square(20);

            Console.WriteLine(square.GetFigurePerimeter());
            Console.WriteLine(square.GetFigureArea());

            Rectangle rectangle = new Rectangle();
            rectangle.GetInfo();

            Rectangle rectangle1 = new Rectangle(20, 30);

            Console.WriteLine(rectangle.GetFigurePerimeter());
            Console.WriteLine(rectangle.GetFigureArea());

            Triangle triangle = new Triangle();
            triangle.GetInfo();

            Triangle triangle1 = new Triangle(16, 26, 36, 27);

            Console.WriteLine(triangle.GetFigurePerimeter());
            Console.WriteLine(triangle.GetFigureArea());

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
