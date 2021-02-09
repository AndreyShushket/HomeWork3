using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Triangle : Figure
    {
        public int firstSide;
        public int secondSide;
        public int thirdSide;
        public int hight;

        public Triangle(int firstSide, int secondSide, int thirdSide, int hight)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            this.hight = hight;
            Console.WriteLine($"Triangle; firstSide: { this.firstSide}, secondSide: { this.secondSide}, thirdSide: { this.thirdSide}, hight: { this.hight}");
        }

        public Triangle()
        {
            firstSide = 15;
            secondSide = 25;
            thirdSide = 35;
            hight = 17;
        }
        public static double GetPerimeter(int firstSide, int secondSide, int thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }

        public static double GetArea(int firstSide, int hight)
        {
            return 0.5 * firstSide * hight;
        }

        public override double GetFigurePerimeter()
        {
            return firstSide + secondSide + thirdSide;
        }

        public override double GetFigureArea()
        {
            return 0.5 * firstSide * hight;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Triangle; firstSide: {firstSide}, secondSide: {secondSide}, thirdSide: {thirdSide}, hight: {hight},");
        }
    }
}
