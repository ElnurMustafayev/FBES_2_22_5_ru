#include <iostream>

using namespace std;

class Test {
    double d = 0;
};


int Func3(int& counter) {
    return ++counter;
}

int Func2Counter = 0;
int Func2() {
    return ++Func2Counter;
}

int Func1() {
    static int counter = 0;

    // code...

    return ++counter;
}


template<class T>
class NonStaticCalc {
    T x;
    T y;
public:
    NonStaticCalc(T x, T y)
    {
        this->x = x;
        this->y = x;
    }

    T sum() {
        return this->x + this->y;
    }

    T minus() {
        return this->x - this->y;
    }
};


template<class T>
struct StaticCalc {
    static T sum(T num1, T num2) {
        return num1 + num2;
    }

    static T minus(T num1, T num2) {
        return num1 - num2;
    }
};






struct MyStruct {
    int num = 0;
    static int counter;

    void NonStatic() {
        this->num++;
    }

    static void Static() {
        MyStruct::counter++;
    }
};

int MyStruct::counter = 0;



class Person {
public:
    static int peopleCount;
    string name;
    string surname;
    int age = 0;


    Person() {
        Person::peopleCount++;
        this->age = -1;
    }

    Person(int) : Person() {

    }

    Person(string name, string surname) : Person(0)
    {
        //Person();
        Person::peopleCount++;
        this->name = name;
        this->surname = surname;
        this->age = -2;
    }
};

int Person::peopleCount = 0;

int main()
{
    if (true) {
        auto p1 = Person("Elnur", "Mustafayev");    // 2
        auto p2 = Person();                         // 3

        cout << (p1.peopleCount == p2.peopleCount) << endl;     // 1
        cout << p1.peopleCount << endl;                         // 3
        cout << p2.peopleCount << endl;                         // 3
    }

    if (false) {
        auto p1 = Person("Elnur", "Mustafayev");
        auto p2 = Person();
        auto p3 = Person("Bob", "Marley");
        auto p4 = Person();

        cout << p2.peopleCount << endl;

        cout << "Age p1: " << p1.age << endl;
        cout << "Age p2: " << p2.age << endl;
        cout << "Age p3: " << p3.age << endl;
        cout << "Age p4: " << p4.age << endl;
    }

    if (false) {
        MyStruct obj1 = MyStruct();
        MyStruct obj2 = MyStruct();

        MyStruct::Static();      // 1
        MyStruct::Static();      // 2
        MyStruct::Static();      // 3

        MyStruct::Static();      // 4

        cout << obj1.counter << endl;
        cout << obj2.counter << endl;

        MyStruct obj3 = MyStruct();
        cout << obj3.counter << endl;

        cout << MyStruct().counter << endl;
        cout << MyStruct::counter << endl;
    }

    if (false) {
        MyStruct obj1 = MyStruct();
        MyStruct obj2 = MyStruct();

        obj1.NonStatic();
        obj1.NonStatic();
        obj1.NonStatic();   // 3

        obj2.NonStatic();   // 1

        cout << obj1.num << endl;
        cout << obj2.num << endl;
    }




    /*MyStruct();
    MyStruct();
    MyStruct();
    cout << MyStruct::counter << endl;*/



    /*cout << MyStruct::counter << endl;
    MyStruct::counter++;
    MyStruct::counter++;
    MyStruct::counter++;
    cout << MyStruct::counter << endl;*/

    /*MyStruct::Say("Test");
    MyStruct::Say("salam");
    MyStruct::Say("hello");*/





    /*NonStaticCalc<int> calc = NonStaticCalc<int>(15, 15);
    cout << calc.sum() << endl;
    cout << calc.minus() << endl;

    cout << StaticCalc<double>::sum(12, 45) << endl;
    cout << StaticCalc<int>::minus(12, 45) << endl;*/

    /*Calc calc = Calc();
    cout << calc.sum(12, 45.5) << endl;
    cout << calc.minus(78.45, 98.4) << endl;*/





    /*int counter = 0;
    while (Func3(counter) < 10) {
        cout << Func3(counter) << endl;
    }*/

    //while (Func2() < 10) {
    //    cout << Func2() << endl; // 2 ... 10
    //}

    //while (Func1() < 10) {
    //    cout << Func1() << endl; // 2 ... 10
    //}




    /*static int num = 10;

    num += 10;

    cout << num << endl;*/
}