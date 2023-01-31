#include <iostream>

using namespace std;


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
struct StaticCalc {
    static T sum(T num1, T num2) {
        return num1 + num2;
    }

    static T minus(T num1, T num2) {
        return num1 - num2;
    }
};


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



int main()
{
    NonStaticCalc<int> calc = NonStaticCalc<int>(15, 15);
    cout << calc.sum() << endl;
    cout << calc.minus() << endl;

    cout << StaticCalc<double>::sum(12, 45) << endl;
    cout << StaticCalc<int>::minus(12, 45) << endl;

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