using System;

namespace RyadkiLibrary
{
    public class Ryadki
    {
        protected string str;
        public Ryadki(string line)
        {
            str = line;
        }
        public string GetRyadok
        {
            get { return str; }
        }
        public virtual int RyadokLength()
        {
            return str.Length;
        }
        public virtual void InsertSymbols()
        {
            string s = ", isn't it ?";
            str = str + s;
        }
    }
}
