using System;

namespace ClassLibrary1
{
    public class Circle
    {
        private int Radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public static double GetPerimeter(int radius)
        {
            return 2 * Math.PI * radius; ;
        }

        public static double GetArea(int radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
