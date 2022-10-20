#include <iostream>

using namespace std;

int main()
{
    /*int num = 0;

    while (++num <= 100) {
        if (num % 2 == 1)
            continue;

        cout << num << endl;
    }*/



    /*for (int num = 0; num < 10; num++)
    {
        cout << num << endl;
    }*/

    /*for (int num = 10; num >= 0; num--) {
        cout << num << endl;
    }*/


    /*for (char i = 10; i < 100; i++)
    {
        cout << i << endl;
    }*/



    /*
    bool isUpper = true;

    char startSymbol = isUpper ? 'A' : 'a';

    for (char i = 0; i <= 25; i++) {
        cout << (char)(startSymbol + i) << endl;
    }
    */



    /*for (int i = 1; i < 50; i++)
    {
        int result = i * 5;

        if (!(result % 100))
            break;

        cout << result << endl;
    }*/


    int toGuess = 50;

    int num = 0;
    for (int i = 3; i > 0; i--)
    {
        cout << "You have " << i << " tries to guess: ";
        cin >> num;

        if (num != toGuess)
            continue;

        cout << "Congratulations!!!" << endl;
        break;
    }
}