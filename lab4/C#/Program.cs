using System;
using VectorLibrary;

namespace laba4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Input coordinates (x;y): ");
            x= Convert.ToInt32(Console.ReadLine());
            y =Convert.ToInt32(Console.ReadLine());
            Vector V1 = new Vector();
            Vector V2 = new Vector(x,y);
            Vector V3 = new Vector(V1);
            Console.WriteLine("All vectors: ");
            V1.Information();
            V2.Information();
            V3.Information();                          //copy vector V1
            V1 = V3 - V2;
            Console.WriteLine("\n----------------\nVector V1=V3-V2: ");
            V1.Information();
            Console.WriteLine("\n----------------\nVector V3=2*V3: ");
            V3 = 2 * V3;
            V3.Information();
        
            Console.ReadKey();

        }
    }
}
