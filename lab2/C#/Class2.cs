using System;
using MyStringg;

namespace Textt
{
    public class Text
    {
        private int _amountOfstrings;
        private MyString[] _text;
        public Text(MyString line)
        {
            _text = new MyString[1];
            _text[0] = line;
            _amountOfstrings++;
        }
        public void AddToText(MyString line)               //добавление рядка к тексту
        {
            MyString[] temp_arr = new MyString[_amountOfstrings + 1];
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
        }
        public void OutputText(char[][] TEXT, int amount)              //вывод текста
        {
            for (int i = 0; i < amount; i++)
            {
                int j = 0;
                while (TEXT[i][j] != '\0')
                {
                    Console.Write(TEXT[i][j]);
                    j++;
                }
                Console.WriteLine();
            }
        }
        public char[][] GetText()                            //получение двумерного массива, содержащего в себе строки текста
        {
            char[][] TEXT = new char[_amountOfstrings][];
            for (int i = 0; i < _amountOfstrings; i++)
            {
                char[] line = _text[i].GetLine();
                TEXT[i] = new char[_text[i].GetSize()];
                for (int j = 0; j < _text[i].GetSize(); j++)
                {
                    TEXT[i][j] = line[j];
                }
            }
            return TEXT;
        }
        public void DeleteText()                   //очищение всего текста
        {
            _text = new MyString[0];
            _amountOfstrings = 0;
        }
        public void DeleteLine(int index)              //удаление рядка
        {
            MyString[] temp = new MyString[_amountOfstrings - 1];
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
        }
        public void DeleteLineWithSubstr(char[] sub, int size)              //удаление строки, что содержит в себе заданную подстроку
        {
            for (int i = 0; i < _amountOfstrings; i++)
            {
                if (_text[i].SubstringFind(sub, size))
                    DeleteLine(i);
            }
        }
        public double AverageLength()                      //вычисление средней длины рядков в тексте
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
        public double PercentageOfVowels()                     //вычисление процента содердания гласных букв во всем тексте
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
            percent = 2 * (sum_vowels - 2) / (sum_letters - 2) * 100;
            return percent;
        }
        public int GetAmountOfLines()              //получение количества строк в тексте
        {
            return _amountOfstrings;
        }
    }
}
