#include <iostream>

using namespace std;

int main()
{
    //int arr[5];

    const int xLength = 3, yLength = 3;

    int duoArray[3][3]{
        {1,2,5},
        {3,4},
        {}
    };

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
}