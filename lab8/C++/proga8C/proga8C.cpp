#include<iostream>
#include <stdlib.h>  
using namespace std;

class Node
{
public:
    int Data;
    Node* Next;
    Node(int data)
    {
        Data = data;
    }
};

class LinkedList
{
private:
    Node* _head;
    Node* _tail;
    int _size;

public:
    LinkedList()
    {
        _head = NULL;
        _tail = NULL;
        _size = 0;
    }
    void Add(int data)
    {
        Node* node_add = new Node(data);
        if (_head == NULL)
        {
            _head = node_add;
            _tail = _head;
        }
        else
        {
            _tail->Next = node_add;
        }
        _tail = node_add;
        _size++;
    }
    void RemoveAfterIndex(int index)
    {
        Node* current = _head;
        for (int i = 0; i < index; i++)
        {
            current = current->Next;
        }
        _tail = current;
        _tail->Next = NULL;
    }
    int FindMax()
    {
        Node* current = _head;
        int count = 0;
        int max = current->Data;
        while (current->Next != NULL)
        {
            if (max < current->Next->Data)
            {
                max = current->Next->Data;
                count++;
            }
            current = current->Next;
        }
        return count;
    }
    int FindAmountOf5()
    {
        Node* current = _head;
        int count = 0;
        while (current != NULL)
        {
            if (current->Data % 5 == 0)
            {
                count++;
            }

            current = current->Next;
        }
        return count;
    }

    void Output()
    {
        Node* current = _head;
        cout << "The list: " << endl;
        while (current != NULL)
        {
            cout << current->Data << endl;
            current = current->Next;
        }
    }
};

int main()
{
    LinkedList list =LinkedList();
    list.Add(34);
    list.Add(86);
    list.Add(555);
    list.Add(1000);
    list.Add(85);
    list.Add(-15);
    list.Output();
    cout<<"\nNumber of multiples of 5= "<< list.FindAmountOf5()<<"\n"<<endl;
    list.RemoveAfterIndex(list.FindMax());
    list.Output();
    system("pause");
    return 0;

}