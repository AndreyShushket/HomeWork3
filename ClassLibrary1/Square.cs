using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Square
    {
        private int Side;

        public Square(int side)
        {
            Side = side;
        }

        public static double GetPerimeter(int side)
        {
            return 4 * side ;
        }

        public static double GetArea(int side)
        {
            return side * side;
        }
    }
}
