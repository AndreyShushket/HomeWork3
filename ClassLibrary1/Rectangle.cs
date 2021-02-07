using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Rectangle : Figure
    {
        public int firstSide;
        public int secondSide;

        public Rectangle(int firstSide, int secondSide)
        {

        }

        public Rectangle()
        {
            firstSide = 15;
            secondSide = 25;
        }
        public static double GetPerimeter(int firstSide, int secondSide)
        {
            return 2 * (firstSide + secondSide);
        }

        public static double GetArea(int firstSide, int secondSide)
        {
            return firstSide * secondSide;
        }

        public override double GetFigurePerimeter()
        {
            return 2 * (firstSide + secondSide);
        }

        public override double GetFigureArea()
        {
            return firstSide * secondSide;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Rectangle; firstSide: {firstSide}, secondSide: {secondSide} ");
        }
    }
}
