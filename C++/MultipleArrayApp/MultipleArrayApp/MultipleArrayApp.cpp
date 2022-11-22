#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;

void PrintDoubleArray1(int arr[][3], const int arraysCount, const int elementsCount) {
    for (int y = 0; y < arraysCount; y++)
    {
        for (int x = 0; x < elementsCount; x++)
        {
            cout << arr[y][x] << " ";
        }
        cout << endl;
    }
}

void PrintDoubleArray2(int arr[][3], const int rows, const int columns) {
    int* start = arr[0];

    for (int y = 0; y < rows; y++)
    {
        for (int x = 0; x < columns; x++)
        {
            cout << *(start + (y * columns) + x) << "\t";
        }
        cout << endl;
    }
}


void PrintDoubleArray3(int* start, const int rows, const int columns) {
    /*for (int i = 0; i < (rows * columns); i++)
    {
        if (i % columns == 0 && i >= columns)
            cout << endl;

        cout << *(start + i) << "\t";
    }*/

    for (int y = 0; y < rows; y++)
    {
        int* currentArr = (start + (y * columns));
        for (int x = 0; x < columns; x++)
        {
            cout << currentArr[x] << "\t";
        }
        cout << endl;
    }
}

int main()
{
    /*const int rows = 4;
    const int columns = 3;

    int duoArray[rows][columns]{
        {1,2,5},
        {3,4,6},
        {7,8,9},
        {12,24,45}
    };

    PrintDoubleArray3(*duoArray, rows, columns);*/


    //int arr[5];

    /*const int xLength = 3, yLength = 3;

    int duoArray[3][3]{
        {1,2,5},
        {3,4},
        {}
    };*/

    /*int tetraArr[3][3][3]{

    };*/

    /*for (size_t y = 0; y < yLength; y++)
    {
        for (size_t x = 0; x < xLength; x++)
        {
            cout << duoArray[y][x] << " ";
        }
        cout << endl;
    }*/

    /*for (int y = 0, x = 0; y < yLength; x++)
    {
        cout << duoArray[y][x] << " ";

        if (x == xLength - 1) {
            x = -1;
            y++;
            cout << endl;
        }
    }*/


    //cout << duoArray[2][2] << endl;

    //cout << sizeof(duoArray) << endl;



    /*int duoArray[3][3]{
        {1,2,5},
        {3,4,6},
        {7,8,9}
    };*/

    /*int* ptr = duoArray[0];
    cout << ptr[1] << endl;*/

    /*cout << duoArray << endl;
    cout << duoArray[0] << endl;
    cout << duoArray[1] << endl;
    cout << duoArray[2] << endl;*/




    /*int arr[1][1][1];

    cout << arr << endl;
    cout << arr[0] << endl;
    cout << arr[0][0] << endl;*/


    char dest[50] = "Hello";
    char source[20] = "World";

    //strcpy(dest, source);

    /*strcat(dest, " ");
    strcat(dest, source);*/

    //cout << dest << endl;

    //cout << strlen(dest) << endl;   // 5
}