using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Square : Figure
    {
        public int Side;

        public Square(int Side)
        {

        }

        public Square()
        {
            Side = 15;
        }

        public static double GetPerimeter(int Side)
        {
            return 4 * Side;
        }

        public static double GetArea(int Side)
        {
            return Side * Side;
        }

        public override double GetFigurePerimeter()
        {
            return 4 * Side;
        }

        public override double GetFigureArea()
        {
            return Side * Side;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Square; Side: {Side}");
        }
    }
}
