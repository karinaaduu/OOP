#pragma once
#include<iostream>
#define _USE_MATH_DEFINES
#include<math.h>
using namespace std;

class LineC
{
protected:
    double first_x, first_y, second_x, second_y;
public:
    LineC(double x1, double y1, double x2, double y2);
    double Length();
};

class SegmentC :public LineC
{
public:
    SegmentC(double x1, double y1, double x2, double y2);
    double Angle();
    void first_point();
    void second_point();
};
