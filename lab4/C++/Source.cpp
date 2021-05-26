#include"Header.h"

Vector::Vector(double x, double y)  //конструктор з параметрами
{
    _x = x;
    _y = y;
    CalculateLength();
}
Vector::Vector()                 //конструктор за замовчуванням
{
    _x = 1;
    _y = 1;
    CalculateLength();
}
Vector::Vector(const Vector& v) :             //конструктор копіювання
    _x(v._x), _y(v._y), _length(v._length)
{
    CalculateLength();
}
void Vector::CalculateLength()                   //розрахунок довжини вектора
{
    _length = sqrt((pow(_x, 2) + pow(_y, 2)));
}
void Vector::Information()               //інформація щодо вектора
{
    cout << "\nCoordinates: (" << _x << ";" << _y << ")" << endl;;
    cout << "Length: " << _length << endl;
}
Vector operator *(int n, Vector v)
{
    v._x = v._x * n;
    v._y = v._y * n;
    return v;
}
Vector Vector::operator-(const Vector & v1)
{
    Vector temp;
    temp._x = this->_x - v1._x;
    temp._y = this->_y - v1._y;
    return temp;
}