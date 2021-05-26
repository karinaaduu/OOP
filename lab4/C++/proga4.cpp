#include"Header.h"

int main()
{
    double x, y;
    cout << "Input coordinates (x;y):" << endl;
    cin >> x >> y;
    Vector V1 = Vector();
    Vector V2 = Vector(x, y);
    Vector V3 = Vector(V1);
    cout << "All vectors: " << endl;
    V1.Information();
    V2.Information();
    V3.Information();                          //copy vector V1
    V1 = V3-V2;
    cout << "\n----------------\nVector V1=V3-V2: " << endl;
    V1.Information();
    cout << "\n----------------\nVector V3=2*V3: " << endl;
    V3 = 2 * V3;
    V3.Information();
    system("pause");
    return 0;
}