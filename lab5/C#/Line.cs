using System;

namespace LineLibrary
{
    public class Line
    {
        protected double first_x, first_y, second_x, second_y;
        public Line(double x1, double y1, double x2, double y2)
        {
            first_x = x1;
            first_y = y1;
            second_x = x2;
            second_y = y2;
        }
        public double Length()
        {
            return (Math.Sqrt(Math.Pow((second_x - first_x), 2) + Math.Pow((second_y - first_y), 2)));
        }
        
    }
}
