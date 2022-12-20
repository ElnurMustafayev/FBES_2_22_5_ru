#include <iostream>

using namespace std;

template<typename T>
T** GetMultArray(const int* lengthes, const int length) {
    T** resultArr = new T* [length];

    for (int i = 0; i < length; i++)
        resultArr[i] = new T[lengthes[i]] {};

    return resultArr;
}

template<typename T>
void PrintArray(T** arr, const int* lengthes, const int length) {
    for (int i = 0; i < length; i++)
    {
        cout << "[" << i << "]: \t";
        for (int j = 0; j < lengthes[i]; j++)
        {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }
}

template<typename T>
void DeleteArray(T** arr, const int length) {
    for (int i = 0; i < length; i++)
        delete[] arr[i];

    delete[] arr;
}



int main()
{
    /*auto num = double(123);

    cout << (num % 4) << endl;*/

    /*int length = 3;
    int* lengthes = new int[length] {8, 3, 15};

    auto result = GetMultArray<int>(lengthes, length);
    PrintArray(result, lengthes, length);
    DeleteArray(result, length);
    delete[] lengthes;*/

    /*int** arr = new int* [3] {
        new int[3] {},
        new int[3] {},
        new int[3] {},
    };

    for (int y = 0; y < 3; y++)
    {
        for (int x = 0; x < 3; x++)
        {
            arr[y][x] = rand();
        }
    }*/


    //int** arr = new int* [3] {};
    /*const char** names = new const char* [10] {
        "Test"
    };*/

    /*char* symbol = new char('a');

    int** arr = new int* [5] {
        new int(3),
        new int[2] {},
        (int*)symbol
    };

    for (int i = 0; i < 3; i++)
    {
        delete *(arr + i);
        delete arr[i];
    }

    delete[] arr;*/


    /*int* test = new int[3];

    int** arr = new int* [3] {
        new int[3],
        test,
        new int[3] {5, 6}
    };
    cout << arr[0][2] << endl;
    cout << arr[1][2] << endl;
    cout << *(*(arr + 1) + 2) << endl;*/


    /*int* arr = new int[3]{ 4,5 };

    cout << arr[2] << endl;*/



    //int* arr = new int[5] {3, 5, 8, 2, 4};

    //Func(arr, 5) -> int**


    //Func([2,3,4], 3) -> arr[arr1[2],arr2[3],arr3[4]]

}