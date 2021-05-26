using System;

namespace ExeptionsLibrary
{
    public class Exeptions
    {
        private double _a, _c, _d;
        public double Computation { get; private set; }
        public Exeptions(double a, double c, double d)
        {
            _a = a;
            _c = c;
            _d = d;
        }
        public void Exp()
        {
            if (_a == 0)
                throw new DivideByZeroException();
            if (_a >= 4)
                throw new ArgumentException();
            Computation = Func();
        }
        private double Func()
        {
            return ((2 * _c - _d / 23) / Math.Log(1 - _a / 4));
        }
        public (double, double, double) GetArguments
        { get { return (_a, _c, _d); } }
    }
}
