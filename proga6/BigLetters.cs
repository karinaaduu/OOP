using System;
using RyadkiLibrary;

namespace BigLettersLibrary
{
    public class BigLetters:Ryadki
    {
        public BigLetters(string line) : base(line)
        { }
        public override int RyadokLength()
        {
            return str.Length;
        }
        override public void InsertSymbols()
        {
            string newstr = "";
            for (int i = 1; i < str.Length; i += 2)
            {
                newstr = str.Insert(i, "/");
                str = newstr;
            }
        }
    }
}
