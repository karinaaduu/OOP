using System;
using RyadkiLibrary;
using SmallLettersLibrary;
using BigLettersLibrary;

namespace proga6
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "The moon is so beautiful today";
            Ryadki ryadok = new Ryadki(stroka);
                   
            Console.WriteLine($"\nUsing Base class Ryadok:\nValue: {ryadok.GetRyadok}");
            Console.WriteLine($"Length: {ryadok.RyadokLength()}");
            ryadok.InsertSymbols();
            Console.WriteLine($"After insertion: {ryadok.GetRyadok}");
            Console.WriteLine($"Length: {ryadok.RyadokLength()}");

            ryadok = new BigLetters(stroka);
            Console.WriteLine($"\nUsing Derivative class BigLetters:\nValue: {ryadok.GetRyadok}");
            Console.WriteLine($"Length: {ryadok.RyadokLength()}");
            ryadok.InsertSymbols();
            Console.WriteLine($"After insertion: {ryadok.GetRyadok}");
            Console.WriteLine($"Length: {ryadok.RyadokLength()}");

            ryadok = new SmallLetters(stroka);
            Console.WriteLine($"\nUsing Derivative class SmallLetters:\nValue: {ryadok.GetRyadok}");
            Console.WriteLine($"Length: {ryadok.RyadokLength()}");
            ryadok.InsertSymbols();
            Console.WriteLine($"After insertion: {ryadok.GetRyadok}");
            Console.WriteLine($"Length: {ryadok.RyadokLength()}");
            Console.ReadKey();
        }
    }
}
