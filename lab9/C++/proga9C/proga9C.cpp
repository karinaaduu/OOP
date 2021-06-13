#include<iostream>
using namespace std;

class Array {
private:
    char* _array;
    int _size;

public:
    Array(char* array, int size) 
    {
        _array = array;
        _size = size;
    }
    char* array() 
    {
        return _array;
    }
    int size() {
        int size = 0;
        while (&_array[size] != nullptr) {
            size++;
        }
    };
    void Sorter() {
        for (int i = 0; i < this->_size; ++i) {
            for (int j = 0; j < this->_size - 1; ++j) {
                if (_array[j] > _array[j + 1]) {
                    char tmp = _array[j];
                    _array[j] = _array[j + 1];
                    _array[j + 1] = tmp;
                }
            }
        }
    }
    static void Sorter(char* _array, int size) {
        for (int i = 0; i < size; ++i) {
            for (int j = 0; j < size - 1; ++j) {
                if (_array[j] > _array[j + 1]) {
                    char tmp = _array[j];
                    _array[j] = _array[j + 1];
                    _array[j + 1] = tmp;
                }
            }
        }
    }
};

void Out(char* _array, int size) {
    for (int i = 0; i < size; ++i) {
        cout << _array[i] << " ";
    }
    cout << endl;
}

int main() {
    void (*Function)(char* _array, int size) = Array::Sorter;
    char* array1 = new char[3];
    array1[0] = 'a';
    array1[1] = 'd';
    array1[2] = 'c';
    char* array2 = new char[5];
    array2[0] = '5';
    array2[1] = '4';
    array2[2] = '3';
    array2[3] = '2';
    array2[4] = '1';
    Array array3(array2, 5);
    Out(array1, 3);
    
    Out(array3.array(), 5);
    array3.Sorter();
    
    cout << "Static function"<< endl;
    Function(array1, 3);
    Out(array1, 3);
    cout << "Exemplary function" << endl;
    Out(array3.array(), 5);
    system("pause");
    return 0;
}
