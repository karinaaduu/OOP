#pragma once
#include "Header.h"

class Ryadki
{
protected: string str;
public:
    Ryadki(string line)
    {
        str = line;
    }
    string GetRyadok()
    {
        return str;
    }
    virtual int RyadokLength()
    {
        return str.length();
    }
    virtual void InsertSymbols()
    {
        string s = ", isn't it ?";
        str = str + s;
    }
};
