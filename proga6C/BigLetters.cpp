#pragma once
#include "Header.h"
#include "Ryadki.cpp"

class BigLetters :public Ryadki
{
public:
    BigLetters(string line) :Ryadki(line)
    { }
    int RyadokLength() override
    {
        return str.length();
    }
    void InsertSymbols() override
    {
        string newstr = "";
        for (int i = 1; i < str.length(); i += 2)
        {
            newstr = str.insert(i, "/");
            str = newstr;
        }
    }
};