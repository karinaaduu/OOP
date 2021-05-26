#pragma once
#include<iostream>
#include<cmath>
using namespace std;
class Vector
{
private:
    double _x, _y, _length;
    void CalculateLength();
public:
    Vector();
    Vector(double x, double y);
    Vector(const Vector& v);
    void Information();

    friend Vector operator*(int n, Vector v);
    Vector operator-(const Vector& v1);
   
};