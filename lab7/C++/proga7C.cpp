#include "Header.h"
#include "Exceptions.cpp"

int main()
{
    Exeptions* obj_arr=new Exeptions[4];
    obj_arr[0] = Exeptions(3, 2, 1); // right
    obj_arr[1] = Exeptions(2.75, 34.2, -8.274); // right
    obj_arr[2] = Exeptions(0, 23, -7); // devision by 0 (a=0)
    obj_arr[3] = Exeptions(10, 11, 12); // wrong  (a>4)
    for (int i = 0; i < 4; i++)
    {
        try
        {
         
            cout << "For expression" << i;
            obj_arr[i].GetArguments();
            obj_arr[i].Exp();
            cout << "\n\n";
        }
        catch (exception ex)
        {
            cout << "We have " << ex.what() <<"\n\n";
        }
    }
    system("pause");
    return 0;
}