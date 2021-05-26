using System;
using LineLibrary;
namespace SegmentLibrary
{
    public class Segment:Line
    {
        public Segment(double x1, double y1, double x2, double y2): base(x1, y1, x2, y2)
        { }
        public double Angle()
        {
            return (Math.Acos(Math.Abs(second_x - first_x) / Length()) * 180 / Math.PI);
        }
        public (double, double) get_first_point()
        {
            return (first_x, first_y);
        }
        public (double, double) get_second_point()
        {
            return (second_x, second_y);
        }
    }
}
