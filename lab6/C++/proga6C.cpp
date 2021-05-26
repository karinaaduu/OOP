#include "Header.h"
#include "Ryadki.cpp"
#include "BigLetters.cpp"
#include "SmallLetters.cpp"

int main()
{
        string stroka = "The moon is so beautiful today";
        Ryadki ryadok(stroka);

        cout << "\nUsing Base class Ryadok:\nValue: " << ryadok.GetRyadok() << endl;
        cout << "Length: " << ryadok.RyadokLength() << endl;
        ryadok.InsertSymbols();
        cout << "After insertion: " << ryadok.GetRyadok() << endl;
        cout << "Length: " << ryadok.RyadokLength() << endl;
        BigLetters bigryadok(stroka);
        cout << "\nUsing Derivative class BigLetters:\nValue: " << bigryadok.GetRyadok() << endl;
        cout << "Length: " << bigryadok.RyadokLength() << endl;
        bigryadok.InsertSymbols();
        cout << "After insertion: " << bigryadok.GetRyadok() << endl;
        cout << "Length: " << bigryadok.RyadokLength() << endl;
        SmallLetters smallryadok(stroka);
        cout << "\nUsing Derivative class SmallLetters:\nValue: " << smallryadok.GetRyadok() << endl;
        cout << "Length: " << smallryadok.RyadokLength() << endl;
        smallryadok.InsertSymbols();
        cout << "After insertion: " << smallryadok.GetRyadok() << endl;
        cout << "Length: " <<smallryadok.RyadokLength() << endl;
        system("pause");
        return 0;
}