#include <iostream>
#include "BankCard.h"
#include "Int.h"
#include "String.h"

using namespace std;

int main()
{
    /*
    BankCard card = BankCard("1234123412341234", "456");
    
    cout << "Operation: " << ((card += 50) ? "ok" : "error") << endl;
    cout << "Operation: " << ((card += -50) ? "ok" : "error") << endl;

    card.AddMoney(50);
    card.AddMoney(-80);

    card.Info();
    */



    /*Int num = 5;
    Int result = (num + 5);

    num += num++;

    result++;
    ++result;

    cout << (num != result) << endl;*/


    //num.operator--(1).operator+(num.operator--());
    //cout << (--num + num--).GetValue() << endl;
    //cout << num.GetValue() << endl;
    //cout << result.GetValue() << endl;

    // string / char[]
    String str = "start";

    //str += (str + "qwerty");

    str *= 3;

    cout << str.value << endl;
}