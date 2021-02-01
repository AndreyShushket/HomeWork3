using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Rectangle
    {
        private int firstSide;
        private int secondSide;

        public static double GetPerimeter(int firstSide, int secondSide)
        {
            return 2 * (firstSide + secondSide);
        }

        public static double GetArea(int firstSide, int secondSide)
        {
            return firstSide * secondSide;
        }
    }
}
