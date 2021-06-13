using System;
using System.Xml;

namespace proga8
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
        }
    }

    public class LinkedList
    {
        private Node _head;
        private Node _tail;
        private int _size;

        public LinkedList()    //конструктор для инициализвции полей
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public void Add(int data)      //метод добавления обїектов к списку
        {
            Node node_add = new Node(data);
            if (_head == null)    //самый первый элемент
            {
                _head = node_add;
                _tail = _head;
            }
            else //добавление элементов к списку
            {
                _tail.Next = node_add;
                _tail = _tail.Next;
            }
            _size++; //размер списка
        }

        public void RemoveAfterIndex(int index) //удаление всех объектов после максимального заданного объекта
        {
            Node current = _head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            _tail = current;
            _tail.Next = null;
        }
        public int FindMax()       //нахождение макс элемента
        {
            Node current = _head;
            int count = 0;
            int max = current.Data;
            while (current.Next != null)
            {
                if (max < current.Next.Data)
                    {
                        max = current.Next.Data;
                        count++;
                    }
                    current = current.Next;
            }
            return count;
        }
        public int FindAmountOf5()    //нахождение количества чисел в списке, кратных 5
        {
            Node current = _head;
            int count = 0;
            while (current != null)
            {
                if (current.Data%5==0)
                {
                    count++;
                }

                current = current.Next;
            }
            return count;
        }

        public void Output()    //вывод списка
        {
            Node current = _head;
            Console.WriteLine("The list: ");
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(34);
            list.Add(86);
            list.Add(555);
            list.Add(1000);
            list.Add(85);
            list.Add(-15);
            list.Output();
            Console.WriteLine($"\nNumber of multiples of 5= { list.FindAmountOf5()}\n");
            list.RemoveAfterIndex(list.FindMax());
            list.Output();
            Console.ReadKey();
        }
    }
}
