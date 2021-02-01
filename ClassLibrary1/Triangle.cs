using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Triangle
    {
        private int firstSide;
        private int secondSide;
        private int thirdSide;
        private int hight;
        

        public static double GetPerimeter(int firstSide, int secondSide, int thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }

        public static double GetArea(int firstSide, int hight)
        {
            return 0.5 * firstSide * hight;
        }
    }
}
