using System;

namespace VectorLibrary
{
    public class Vector
    {
        private double _x, _y;
        public double Length { get; set; }  //властивість, яка дозволяє записати в себе довжину вектора у класі та отримати це значення
        public double X { get { return _x; } }          //властивість для отримання координати абсциси
        public double Y { get { return _y; } }          //властивість для отримання координати ординати
        public Vector(double x, double y)  //конструктор з параметрами
        {
            _x = x;
            _y = y;
        }
        public Vector()                 //конструктор за замовчуванням
        {
            _x = 1;
            _y = 1;
        }
        public Vector(Vector v)             //конструктор копіювання
        {
            _x = v.X;
            _y = v.Y;
            Length = v.Length;
        }
        public void CalculateLength()                   //розрахунок довжини вектора
        {
            Length = Math.Sqrt((Math.Pow(_x, 2) + Math.Pow(_y, 2)));
        }
        public void Information()               //інформація щодо вектора
        {
            CalculateLength();
            Console.WriteLine($"\nCoordinates: ({_x};{_y})");
            Console.WriteLine($"Length: {Length}");
        }
        public static Vector operator *(int n, Vector v1)
        {
            Vector v = new Vector(n * (v1.X), n * (v1.Y));
            return v;
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector v = new Vector(v1.X - v2.X, v1.Y - v2.Y);
            return v;
        }
    }
}
