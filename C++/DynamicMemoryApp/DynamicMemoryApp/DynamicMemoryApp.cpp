#include <iostream>
#include <conio.h>

using namespace std;


/*
int* GetArray() {
    int arr[10]{
        777,2,3,4,5,6,7,8,9
    };

    return arr;
}
*/


//template<typename T>
//int InitArray(int length) {
//    T arr[length]{};    // error
//}



void InitAndPrintRandomNums(int length, int max) {
    int* nums = new int[length] {};

    for (int i = 0; i < length; i++)
    {
        nums[i] = rand() % max;
        cout << nums[i] << ", ";
    }
    cout << "\n\n";
}





template<typename T>
T* GetDynamicArray(int length) {
    T* arr = new T[length] {};

    for (int i = 0; i < length; i++)
    {
        arr[i] = i + 1;
    }

    return arr;
}



double* GetDynamicArray(int length) {
    double* arr = new double[length]{};

    for (int i = 0; i < length; i++)
    {
        arr[i] = i + 1;
    }

    return arr;
}






int main()
{
    int length = 10;
    double* arr = GetDynamicArray<double>(length);

    for (int i = 0; i < length; i++)
    {
        cout << arr[i] << endl;
    }






    /*
    srand(time(0));

    InitAndPrintRandomNums(70, 100);
    InitAndPrintRandomNums(101, 100);
    */


    // create void function
    // init array of integers with selected length
    // set all elements with rand numbers
    // print all




    /*
    int length = 7;

    int* arrDynamic = new int[length] {};

    for (int i = 0; i < length; i++)
    {
        arrDynamic[i] = i * 10;
    }

    for (int i = 0; i < length; i++)
    {
        cout << arrDynamic[i] << ", ";
    }
    */





    /*int arrStatic[5]{
        777, 0, 2222, 0, 5
    };

    int* arrDynamic = new int[5] {
        777, 1, 2222, 0, 5
    };

    cout << arrStatic[1] << endl;
    cout << arrDynamic[1] << endl;*/





    /*
    int num1 = 123;
    int num2 = 123;
    char* symbolPtr1 = new char('a');
    int* numPtr1 = new int(777);

    cout << &num1 << endl;
    cout << &num2 << "\n\n";

    int* numPtr2 = new int(777);

    cout << numPtr1 << endl;
    cout << numPtr2 << endl;
    */


















    // Problems with non-dynamic arrays
    /*
    int arr1[5]{};

    const int length = 5;
    int arr2[length]{};
    int arr3[(length + length)]{};

    int arr4[]{ 1,2,3,4 };



    int length = 5;
    int arr[length]{};  // error
    */





    /*
    int currentLength = 5;
    int marks[1000]{};
    */




    /*
    int currentLenght = 5;
    int marks[10]{ 1,2,3,4,5 };

    marks[currentLenght++] = 6;
    marks[currentLenght++] = 7;
    marks[currentLenght++] = 8;
    for (int i = 0; i < currentLenght; i++)
    {
        cout << marks[i] << endl;
    }
    cout << endl;

    // ok
    marks[currentLenght++] = 9;
    marks[currentLenght++] = 10;
    for (int i = 0; i < currentLenght; i++)
    {
        cout << marks[i] << endl;
    }
    cout << endl;

    // error
    marks[currentLenght++] = 11;
    marks[currentLenght++] = 10;
    for (int i = 0; i < currentLenght; i++)
    {
        cout << marks[i] << endl;
    }
    cout << endl;
    */


    /*
    int* arr = GetArray();

    for (int i = 0; i < 10; i++)
    {
        cout << arr[i] << endl;
    }
    */



    /*
    int familMarks[5]{ 12,11,10,12,1 };
    cout << familMarks[4] << endl;

    int temp = 4;
    familMarks[temp + 1] = 12;
    *(familMarks + temp + 1) = 12;

    cout << familMarks[temp + 1] << endl;
    */
}