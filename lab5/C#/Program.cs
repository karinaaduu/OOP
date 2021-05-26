using System;
using LineLibrary;
using SegmentLibrary;

namespace proga5
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment Example = new Segment(10, 12, 7, 9);
            Console.WriteLine($"  Coordinates: {Example.get_first_point()}, {Example.get_second_point()}");
            Console.WriteLine($"  Length: {Example.Length()}");
            Console.WriteLine($"  Angle: {Example.Angle()}");
            Console.ReadLine();
        }
    }
}
