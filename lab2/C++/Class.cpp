#include"Class.h"

MyString::MyString()                              //конструктор за замовчуванням
{
    _str = nullptr;
    _length = 0;
}
MyString::MyString(char* str, int len)                //конструктор з параметрами
{
    _str = new char[len + 1];
    for (int i = 0; i < len; i++)
    {
        _str[i] = str[i];
    }
    _str[len] = '\0';
    _length = len + 1;
}
bool MyString::SubstringFind(char* sub, int size)                     //нахождение заданной подстроки в строке
{
    bool find = false;
    for (int i = 0; i < _length; i++)
    {
        if (_str[i] == sub[0])
        {
            for (int j = 0; j < size; j++)
            {
                if (_str[i] == sub[j])
                {
                    find = true;
                    i++;
                }
                else
                {
                    find = false;
                    break;
                }
            }
        }
    }
    return find;
}
int MyString::AmountOfVowels()                                                                    //вычисление количества гласных букв в строке
{
    char vowels[11] = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u', '\0' };
    int k = 0;
    for (int i = 0; i < _length; i++)
    {
        for (int j = 0; j < 11; j++)
        {
            if (_str[i] == vowels[j])
                k++;
            else continue;
        }
    }
    return k;
}
char* MyString::GetLine()             //получение значений строки
{
    return _str;
}
int MyString::GetSize()          //получение длины строки
{
    return _length;
}
/*~MyString()
{
    delete[] _str;
}*/

Text::Text()
{
    _text = nullptr;
    _amountOfstrings = 0;
}
void Text::AddToText(MyString line)               //добавление рядка к тексту
{
    MyString* temp_arr = new MyString[_amountOfstrings + 1];
    for (int i = 0; i < _amountOfstrings; i++)
    {
        temp_arr[i] = _text[i];
    }
    temp_arr[_amountOfstrings] = line;
    _amountOfstrings++;
    _text = new MyString[_amountOfstrings];
    for (int i = 0; i < _amountOfstrings; i++)
    {
        _text[i] = temp_arr[i];
    }
    delete[] temp_arr;
}
void Text::OutputText(char** TEXT, int amount)              //вывод текста
{
    for (int i = 0; i < amount; i++)
    {
        int j = 0;
        while (TEXT[i][j] != '\0')
        {
            cout << TEXT[i][j];
            j++;
        }
        cout << '\n';
    }
}
char** Text::GetText()                            //получение двумерного массива, содержащего в себе строки текста
{
    char** TEXT = new char* [_amountOfstrings];
    for (int i = 0; i < _amountOfstrings; i++)
    {
        char* line = _text[i].GetLine();
        TEXT[i] = new char[_text[i].GetSize()];
        for (int j = 0; j < _text[i].GetSize(); j++)
        {
            TEXT[i][j] = line[j];
        }
    }
    return TEXT;
}
void Text::DeleteText()                   //очищение всего текста
{
    _text = new MyString[0];
    _amountOfstrings = 0;
}
void Text::DeleteLine(int index)              //удаление рядка
{
    MyString* temp = new MyString[_amountOfstrings - 1];
    for (int i = 0; i < index; i++)
    {
        temp[i] = _text[i];
    }
    for (int i = index; i < _amountOfstrings - 1; i++)
    {
        temp[i] = _text[i + 1];
    }
    _text = new MyString[_amountOfstrings - 1];
    for (int i = 0; i < _amountOfstrings - 1; i++)
    {
        _text[i] = temp[i];
    }
    _amountOfstrings--;
    delete[] temp;
}
void Text::DeleteLineWithSubstr(char* sub, int size)              //удаление строки, что содержит в себе заданную подстроку
{
    for (int i = 0; i < _amountOfstrings; i++)
    {
        if (_text[i].SubstringFind(sub, size))
            DeleteLine(i);
    }
}
double Text::AverageLength()                      //вычисление средней длины рядков в тексте
{
    double average;
    average = 0;
    for (int i = 0; i < _amountOfstrings; i++)
    {
        average += _text[i].GetSize();
    }
    average = average / _amountOfstrings - 1;
    return average;
}
double Text::PercentageOfVowels()                     //вычисление процента содердания гласных букв во всем тексте
{
    double sum_letters, sum_vowels;
    sum_letters = 0;
    sum_vowels = 0;
    for (int i = 0; i < _amountOfstrings; i++)
    {
        sum_letters += _text[i].GetSize();
        sum_vowels += _text[i].AmountOfVowels();
    }
    double percent;
    percent = (sum_vowels - 2) / (sum_letters - 2) * 100;
    return percent;
}
int Text::GetAmountOfLines()              //получение количества строк в тексте
{
    return _amountOfstrings;
}
/*Text::~Text()
{
    delete[] _text;
}*/