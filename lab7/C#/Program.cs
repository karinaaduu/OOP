using System;
using ExeptionsLibrary;

namespace proga7
{
    class Program
    {
        static void Main(string[] args)
        {

            Exeptions[] obj_arr = new Exeptions[4];
            obj_arr[0] = new Exeptions(3, 2, 1); // right
            obj_arr[1] = new Exeptions(2.75, 34.2, -8.274); // right
            obj_arr[2] = new Exeptions(0, 23, -7); // devision by 0 (a=0)
            obj_arr[3] = new Exeptions(10, 11, 12); // wrong  (a>4)
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    obj_arr[i].Exp();
                    Console.WriteLine($"Evaluating an expression {i} for {obj_arr[i].GetArguments}: {obj_arr[i].Computation}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Evaluating an expression {i} for {obj_arr[i].GetArguments}: Devision by zero. Input correct values.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Evaluating an expression {i} for {obj_arr[i].GetArguments}: Wrong arguments. Input correct values.");
                }
            }
            Console.ReadLine();
        }
    }
}
