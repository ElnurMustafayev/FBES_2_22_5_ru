#include <iostream>
#include "BankCard.h"
#include "Int.h"
#include "String.h"

using namespace std;
class User {
    string name;
    string surname;
    int age;
public:

    User() {};
    User(string name, string surname, int age) : name(name), surname(surname), age(age) {}

    friend ostream& operator<<(ostream& out, const User& user);
    friend istream& operator>>(istream& in, User& user);
    friend void ShowUser(const User& user);
};

ostream& operator<<(ostream& out, const User& user) {
    out << "User info: " << endl;
    out << "Name: " << user.name << endl;
    out << "Surname: " << user.surname << endl;
    out << "Age: " << user.age;

    return out;
}

istream& operator>>(istream& in, User& user) {
    cout << "Input User info: " << endl;
    cout << "Name: ", cin >> user.name;
    cout << "Surname: ", cin >> user.surname;
    cout << "Age: ", cin >> user.age;

    return in;
}


// Student
//  Name    Vova
//  Surame    Ivanov
//  Marks   [12, 5, 3, 10]

// cout << student << endl;
//  "Name:      Vova"
//  "Surame:    Ivanov"
//  "Marks:     [12, 5, 3, 10]"


//void ShowUser(const User& user) {
//    cout << "User info: " << endl;
//    cout << "Name: " << user.name << endl;
//    cout << "Surame: " << user.surname << endl;
//    cout << "Age: " << user.age;
//}

int main()
{
    //User user = { "Bob", "Brown", 23 };
    User user = User();
    
    cin >> user;
    cout << user << endl;


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
    //String str = "start";

    //str += (str + "qwerty");

    //str *= 3;

    //cout << str.value << endl;
}