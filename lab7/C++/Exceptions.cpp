#pragma once
#include"Header.h"

class Exeptions
{
private:
    double _a, _c, _d;
public:
    Exeptions()
    {
        _a = 1;     _c = 1;    _d = 1;
    }
    Exeptions(double a, double c, double d)
    {
        _a = a;
        _c = c;
        _d = d;
    }
    void Exp()
    {
        if (_a == 0)
            throw exception("Devision by zero.");
        if (_a >= 4)
            throw exception("Wrong arguments.");
        cout << "Evaluating an expression: " << Func() << endl;
    }
    void GetArguments()
    {
        cout << "(" << _a << ", " << _c << ", " << _d << ") " << endl;
    }
private:
    double Func()
    {
        return ((2 * _c - _d / 23) / log(1 - _a / 4));
    }
};