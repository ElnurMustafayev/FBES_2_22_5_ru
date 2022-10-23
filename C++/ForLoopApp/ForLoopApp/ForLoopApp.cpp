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


    /*int toGuess = 50;

    int num = 0;
    for (int i = 3; i > 0; i--)
    {
        cout << "You have " << i << " tries to guess: ";
        cin >> num;

        if (num != toGuess)
            continue;

        cout << "Congratulations!!!" << endl;
        break;
    }*/



    /*int i = 0;
    for (; i < 10; i++)
    {
        cout << i << endl;
    }
    cout << i << endl;*/




    /*for (int i = 0; ;i++)
    {
        cout << i << endl;
    }*/



    /*for (int i = 0; i < 10; )
        cout << i++ << endl;*/


    /*for (; ;)
        cout << "Iteration" << endl;*/

    /*
        // init var
        int counter = 0;

        for (; ;) {
            cout << "Iteration" << endl;

            // change var
            counter++;

            // check condition for stop
            if (counter > 2)
                break;
        }
    */



    
    /*for (cout << "Start" << endl; cout << "Condition" << endl; cout << "End iteration" << endl)
    {
        cout << "Start iteration" << endl;
    }*/


    /*for (cout << "a" << endl; cout << "b" << endl; cout << "c" << endl)
    {
        cout << "d" << endl;
    }*/



    /*for (int x = 0, char y = 10; x < 10 && y > 0; x++, y--)
    {
        cout << x << " " << y << endl;
    }*/

    // 1*1 1*2 1*3 1*4 1*5 1*6 1*7 1*8 1*9
    // 2*1 2*2 2*3 2*4 2*5 2*6 2*7 2*8 2*9
    // ...
    // 9*1 9*2 9*3 9*4 9*5 9*6 9*7 9*8 9*9

    
    /*for (int i = 11; i < 100; i++)
    {
        if (i % 10 == 0)
            continue;

        int result = ((int)(i / 10)) * (i % 10);

        cout << result << "\t";

        if (i % 10 == 9)
            cout << endl;
    }*/



    /*for (int x = 1, y = 1; x <= 9; y++)
    {
        cout << x * y << "\t";

        if (y == 9) {
            cout << endl;
            y = 0;
            x++;
        }
    }*/





    /*for (int x = 1; x <= 9; x++)
    {
        for (int y = 1; y <= 9; y++)
        {
            cout << x * y << "\t";
        }
        cout << endl;
    }*/






    
    // aa, ab, ac, ad, ae
    // ba, bb, bc, bd, be
    // ca, cb, cc, cd, ce
    // da, db, dc, dd, de
    // ea, eb, ec, ed, ee



    // 1. for(int)
    /*for (int i = 0; i < 25; i++)
    {
        char first = ('a' + (i / 5));
        char second = ('a' + (i % 5));

        cout << first << second << (second == 'e' ? "\n" : ",");
    }*/



    // 2. for(int, int)
    /*for (char x = 'a', y = 'a'; x <= 'e'; y++)
    {
        cout << x << y << (y == 'e' ? "\n" : ",");

        if (y >= 'e') {
            y = 'a' - 1;
            x++;
        }
    }*/



    // 3. for { for{} }
    /*for (char x = 'a'; x <= 'e'; x++)
    {
        for (char y = 'a'; y <= 'e'; y++)
        {
            cout << x << y << (y == 'e' ? "\n" : ",");
        }
    }*/

    /*int length;
    char symbol;
    cout << "Length: ";
    cin >> length;
    cout << "Symbol: ";
    cin >> symbol;
    
    for (int x = 1; x <= length; x++)
    {
        for (int y = 1; y <= length; y++)
        {
            cout << symbol << " ";
        }
        cout << endl;
    }*/
}