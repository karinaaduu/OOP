using System;
using RyadkiLibrary;

namespace SmallLettersLibrary
{
    public class SmallLetters:Ryadki
    {
        public SmallLetters(string line) : base(line)
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
                newstr = str.Insert(i, "\\");
                str = newstr;
            }
        }
    }
}
