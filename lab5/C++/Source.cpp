#include "Header.h"

LineC::LineC(double x1, double y1, double x2, double y2)
{
    first_x = x1;
    first_y = y1;
    second_x = x2;
    second_y = y2;
}
double LineC::Length()
{
    return (sqrt(pow((second_x - first_x), 2) + pow((second_y - first_y), 2)));
}
SegmentC::SegmentC(double x1, double y1, double x2, double y2) :LineC(x1, y1, x2, y2)
{ }
double SegmentC::Angle()
{
    return (acos(abs(second_x - first_x) / Length()) * 180 / M_PI);
}
void SegmentC:: first_point()
{ 
    cout << "( " << first_x << "; " << first_y << ") ";
}
void SegmentC::second_point()
{
    cout << "( " << second_x << "; " << second_y << ") ";
}

