#pragma once
#include<iostream>
#include<string>
using namespace std;
char* ToChar(string str, int size);


	class MyString
	{
	private:
		char* _str;
		int _length;
	public:
		MyString();
		MyString(char* str, int len);
		bool SubstringFind(char* sub, int size);
		int AmountOfVowels();
		char* GetLine();
		int GetSize();
	};
	class Text {
	private:
		int _amountOfstrings;
		MyString* _text;     
	public:
		Text();
		void AddToText(MyString line);
		void OutputText(char** TEXT, int amount);
		char** GetText();
		void DeleteText();
		void DeleteLine(int index);
		void DeleteLineWithSubstr(char* sub, int size);
		double AverageLength();
		double PercentageOfVowels();
		int GetAmountOfLines();
	};
