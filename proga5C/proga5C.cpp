#include "Header.h"
int main()
{
    SegmentC Example(10, 12, 7, 9);
    cout << "  Coordinates: ";
    Example.first_point();
    Example.second_point();
    cout <<endl<< "  Length: " << Example.Length() << endl;
    cout << "  Angle: " << Example.Angle() << endl;
    system("pause");
    return 0;
}