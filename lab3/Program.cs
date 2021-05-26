using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Array
    {
        private int[,] A; // внутрішній масив елементів
        private int _row; // розмірність масиву
        private int _col;
        // конструктор
        public Array(int row, int col)
        {
            _row = row;
            _col = col;
            A = new int[_row, _col];
            for (int i = 0; i < _row; i++)
                for (int j = 0; j < _col; j++)
                    A[i, j] = i + j;
        }
        // двовимірний індексатор
        public int this[int i, int j]
        {
            get
            {
                if (i >= _row || j >= _col)
                {
                    throw new IndexOutOfRangeException();
                }
                return A[i, j];
            }
        }
        public int Row
        {
            get
            {
                return _row ;
            }
        }
        public int Col
        {
            get
            {
                return _col;
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                int row, col;
                string str;
                Console.WriteLine("Input the size of the array:\nNumber of rows: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number of columns:");
                col = Convert.ToInt32(Console.ReadLine());
                Array arr = new Array(row, col);  // формування масиву з допомогою індексатора                                           
                do {
                    Console.WriteLine("Input the element number:");
                    str = Console.ReadLine();
                if (str == "end")
                    break;
                else if (str == "size")
                {
                    Console.WriteLine($"Number of rows={arr.Row}");
                    Console.WriteLine($"Number of columns={arr.Col}");
                    break;
                }             
                string[] s_arr = str.Split();
                int i = int.Parse(s_arr[0]);
                int j = int.Parse(s_arr[1]);
                    try
                    {
                        Console.WriteLine($"The given element of the array is ={arr[i, j]}");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("You are out of range. Try again.");
                    }
                } while (str!="end");
                Console.ReadKey();
            }
        }
    }


