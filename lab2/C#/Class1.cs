using System;

namespace MyStringg
{
    public class MyString
    {
        private char[] _str;
        private int _length;
        public MyString(char[] str, int len)                //конструктор з параметрами
        {
            _str = new char[len + 1];
            for (int i = 0; i < len; i++)
            {
                _str[i] = str[i];
            }
            _str[len] = '\0';
            _length = len + 1;
        }
        public bool SubstringFind(char[] sub, int size)                     //нахождение заданной подстроки в строке
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
        public int AmountOfVowels()                                                                    //вычисление количества гласных букв в строке
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            int k = 0;
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (_str[i] == vowels[j])
                        k++;
                    else continue;
                }
            }
            return k;
        }
        public char[] GetLine()             //получение значений строки
        {
            return _str;
        }
        public int GetSize()          //получение длины строки
        {
            return _length;
        }
    }
}
