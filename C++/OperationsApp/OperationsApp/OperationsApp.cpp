#include <iostream>

using namespace std;

int main()
{
    // > < >= <= == != 
    
    /*cout << (10 > 5) << endl;
    cout << (5 != 10) << endl;
    cout << (5 == 10) << endl;*/



    // and or not
    // && || !

    /*cout << (true && false) << endl;
    cout << (false || false) << endl;
    cout << !(true && true) << endl;*/

    //cout << ((10 > 15) || !(false)) << endl;
    //cout << !!!(10 == 10) << endl;
    //cout << (!(true && (false || 10 <= 10)) == true) << endl;

    /*int age;
    cin >> age;
    bool isAdult = age >= 18;
    cout << isAdult << endl;*/



    // + - * / % = ...

    /*int num = 123 + 100;
    cout << num << endl;
    cout << (123 + 100) << endl;

    cout << (10.25f + 100) << endl;*/

    //cout << (2147483647 + 2147483647) << endl;

    /*float num = 123.678;
    cout << ((int)num % 10) << endl;*/




    /*int age;
    double money;

    cout << "Age: ", cin >> age;
    cout << "Money: ", cin >> money;

    bool isAdult = age >= 18;
    bool moneySuccess = money >= 10000;

    cout << ((age >= 18) + (money >= 10000)) << endl;*/



    //int num = 100;
    //cout << num + 10 << endl;
    ////num + 10;
    ////num = num + 10;
    //num += 10;
    //cout << num + 20 << endl;


    //counter += 1;
    //counter += 1;
    //counter += 1;
    /*
    int counter = 0;

    // increment
    counter++;
    counter += 1;
    counter = counter + 1;

    // decrement
    counter--;
    counter -= 1;
    counter = counter - 1;

    cout << counter << endl;
    */





    // postfix

    /*int num = 100;

    cout << num++ << endl;

    cout << num << endl;*/

    /*int num = 100;
    
    int temp = num--;

    cout << num << endl;
    cout << temp << endl;*/



    // prefix

    /*int num = 100;

    cout << ++num << endl;
    cout << num << endl;*/


    /*int num = 100;
    int temp = --num;

    cout << num << endl;
    cout << temp << endl;*/



    /*int num = 10;

    int result = (++num + num++);

    cout << num << endl;
    cout << result << endl;*/


    /*int num = 10;

    int result = (--num == 10) + (num-- != 10);

    cout << result << endl;*/


    /*int num = 100;

    if (!(num * (10 <= 10))) {
        cout << "IF" << endl;
    }*/






    // visa, money
    // visa == true && money >= 40000 => success
    // else => nothing...


    /*char userInputForVisa;
    double money;
    cout << "Visa. Enter 'y' if you have: ", cin >> userInputForVisa;
    cout << "Input money: ", cin >> money;

    bool isVisa = userInputForVisa == 'y' || userInputForVisa == 'Y';
    bool isRich = money >= 40000;

    if (isVisa && isRich) {
        cout << "Success" << endl;
    }*/
}