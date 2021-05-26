#include"Class.h"

char* ToChar(string str, int size)              //преобразование типа string в тип char
{
    char* arr = new char[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = str[i];
    }
    return arr;
}

int main()
{
    int act;
    string stroka1 = "Cheri Cheri Lady";
    string stroka2 = "Goin' through emotion";
    string stroka3 = "Love is where you find it";
    string stroka4 = "Listen to your heart";

   
    MyString line1 = MyString(ToChar(stroka1, stroka1.length()), stroka1.length());
    MyString line2= MyString(ToChar(stroka2, stroka2.length()), stroka2.length());
    MyString line3 = MyString(ToChar(stroka3, stroka3.length()), stroka3.length());
    MyString line4 = MyString(ToChar(stroka4, stroka4.length()), stroka4.length());
    
    Text text = Text();
    text.AddToText(line1);
    text.AddToText(line2);
    text.AddToText(line3);
    text.AddToText(line4);

    char** TEXT = text.GetText();                           //массив со строками (текстом)
    cout << "The text: " << endl;
    text.OutputText(TEXT, text.GetAmountOfLines());
    
    cout << endl << "1-add a line \n2-delete a line \n3-clear the text \n4-get average line length \n\
5-get the percentage of vowels in the whole text \n6-delete a line that contains a given substring \n7-see the menu \n0-finish the program";
    do {
        cout << "\nWhat do you want ?" << endl;
        cin >> act;
        switch (act)
        {
        case 1:
        {
            string addline;
            cout << "Write a line:" << endl;
            cin >> addline;
            MyString addline_str = MyString(ToChar(addline, addline.length()), addline.length());       //
            text.AddToText(addline_str);
            TEXT = text.GetText();
            cout << endl<< "The text: " << endl;
            text.OutputText(TEXT, text.GetAmountOfLines());
            break;
        }
        case 2:
        {
            int Index;
            cout << "What line do you want to delete ?" << endl;
            cin >> Index;
            text.DeleteLine(Index-1);
            TEXT = text.GetText();
            cout << endl<< "The text: " << endl;
            text.OutputText(TEXT, text.GetAmountOfLines());
            break;
        }
        case 3:
        {
            text.DeleteText();
            TEXT = text.GetText();
            cout <<endl<< "The text: " << endl;
            text.OutputText(TEXT, text.GetAmountOfLines());
            break;
        }
        case 4:
        {
            cout << "The average length of line: " << endl;
            cout << text.AverageLength() << endl;
            break;
        }
        case 5:
        {
            cout << "The percentage of vowels in the whole text:" << endl;
            cout << text.PercentageOfVowels()<<"%"<< endl;
            break;
        }
        case 6:
        {
            string substr;
            cout << "Enter the substring: " << endl;
            cin >> substr;
            text.DeleteLineWithSubstr(ToChar(substr, substr.length()), substr.length());
            TEXT = text.GetText();
            cout << endl<<"The text: " << endl;
            text.OutputText(TEXT, text.GetAmountOfLines());         
            break;
        }
        case 7:
        {
            cout << endl << "1-add a line \n2-delete a line \n3-clear the text \n4-get average line length \n\
5-get the percentage of vowels in the whole text \n6-delete a line that contains a given substring \n7-see the menu \n0-finish the program";
        }
        case 0:
        {
            break;
        }
        default:
        {
            cout << "Error" << endl;
            break;
        }
        }
    } while (act != 0);
    system("pause");
    return 0;
}

    
    
    
    
    
    
    
   



