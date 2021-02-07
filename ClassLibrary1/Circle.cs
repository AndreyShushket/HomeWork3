using System;

namespace ClassLibrary1
{
    public class Circle : Figure
    {
        public int Radius;

        public Circle(int Radius)
        {

        }

        public Circle()
        {
            Radius = 15;
        }

        public static double GetPerimeter(int radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double GetArea(int radius)
        {
            return Math.PI * (radius * radius);
        }

        public override double GetFigurePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double GetFigureArea()
        {
             return Math.PI* (Radius* Radius);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Circle; Radius: {Radius}");
        }
    }
}
