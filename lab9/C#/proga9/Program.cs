using System;

namespace proga9
{
    class Array
    {
        private int[] _Arr;
        public delegate void AccountHandler( string mes);
        public event AccountHandler Notify;
        public Array(int[] arr)
        {
            _Arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                _Arr[i] = arr[i];
            }
            Notify?.Invoke($"Array is inputed.");
        }
        public void DeleteElement(int index)
        {
            int[] arr = new int[_Arr.Length-1];
            for (int i = 0; i < index; i++)
            {
                arr[i] = _Arr[i];
            }
            for (int i = index; i < _Arr.Length-1; i++)
            {
                arr[i] = _Arr[i + 1];
            }
            _Arr = arr;
            Notify?.Invoke($"Deleted element {index+1}");
            for (int i = 0; i < _Arr.Length; i++)
            {
                Console.WriteLine($" {_Arr[i]} ");
            }
        }
        public static void FunctionST(ref int[] arrST)
        {
            int key, j;
            for (int i = 0; i < arrST.Length; i++)
            {
                key = arrST[i];
                j = i - 1;
                while (j>=0&&arrST[j]<key)
                {
                    arrST[j + 1] = arrST[j];
                    j = j - 1;
                }
                arrST[j + 1] = key;
            }
            Console.WriteLine("Static Method: ");
            for (int i = 0; i < arrST.Length; i++)
            {
                Console.WriteLine($" {arrST[i]} ");
            }
        }
        public void FunctionEX()
        {
            int key, j;
            for (int i = 0; i < _Arr.Length; i++)
            {
                key = _Arr[i];
                j = i - 1;
                while (j >= 0 && _Arr[j] < key)
                {
                    _Arr[j + 1] = _Arr[j];
                    j = j - 1;
                }
                _Arr[j + 1] = key;
            }
            Console.WriteLine("Exemplary method: ");
            for (int i = 0; i < _Arr.Length; i++)
            {
                Console.WriteLine($" {_Arr[i]} ");
            }
            Notify?.Invoke($"You used exemplary method.");
        }
    }
    
    class Program
    {
        delegate void functionST(ref int[] arrST);
        delegate void functionEX();
        
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] {2,46,28,8,-3 };
            int[] arr2 = new int[5] { 23, 88, 34, 9, 1 };

            Array array = new Array(arr2);
            array.Notify += DisplayMessage;
            functionEX del_ex = null;
            del_ex += array.FunctionEX;
            del_ex?.Invoke();
            array.DeleteElement(3);

            functionST del_st = null;
            del_st += Array.FunctionST;
            del_st?.Invoke(ref arr1);
            Console.ReadKey();
        }
        static void DisplayMessage(string mes)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{mes})");
            Console.ResetColor();
        }
    }
}
