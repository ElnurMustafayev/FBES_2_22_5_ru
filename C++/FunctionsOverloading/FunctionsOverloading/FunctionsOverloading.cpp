#include <iostream>

using namespace std;

int ChangeNumber(int num) {
    num = 777;
    return num;
}

//int Func(int num = 5) {
//    return ++num;
//}


//char GetSymbolCode(int symbol) {
//    return symbol;
//}


double Pow(double number, int power) {
    if (power == 0)
        return 1;

    else if (power < 0)
        return 1 / Pow(number, -power);

    double result = number;


    /*for (int i = 0; i < power - 1; i++)
    {
        result *= number;
    }*/
    while (--power)
    {
        result *= number;
    }

    return result;
}

double AutoPow(double number, int power) {
    return pow(number, power);
}




//bool AreSymbolsEqual(int num1, int num2) {
//    bool areLetters = (65 <= toupper(num1) && toupper(num1) <= 90)
//        && (65 <= toupper(num2) && toupper(num2) <= 90);
//
//    if (!areLetters) {
//        cout << "Symbols format is incorrect!" << endl;
//    }
//
//    return (toupper(num1) == toupper(num2));
//}
//
//
//bool AreNumbersEqual(int num1, int num2) {
//    return num1 == num2;
//}


// functions overloading
//void Func(int num1, int num2) {
//    cout << "There are ints!" << endl;
//}
//
//int Func(int number = 123) {
//    cout << "There is an int or default!" << endl;
//}
//
//double Func(char symbol) {
//    cout << "There is a char!" << endl;
//}



// error
//int Func() {
//    return 0;
//}
//
//double Func() {
//    return 0;
//}


//int GetNumber(int num) {
//    for (int i = 0; i < num * num; i++)
//    {
//        if (i == 20)
//            return i;
//    }
//}



//void Func(int num) {
//    cout << "One" << endl;
//}
//
//void Func(char symbol) {
//    cout << "Two" << endl;
//}




bool IsEquals(int num1, int num2) {
    return num1 == num2;
}

bool IsEquals(char symbol1, char symbol2) {
    return toupper(symbol1) == toupper(symbol2);
}

// 1231.343 == 3254.343 => true
// 77.57 == 77.57 => true
// 111.421 == 111.3532 => false
// 42.421 == 74.3532 => false
bool IsEquals(float num1, float num2) {
    int result1 = (num1 - (int)num1) * 100;
    int result2 = (num2 - (int)num2) * 100;

    return result1 == result2;
}

int main()
{
    //cout << IsEquals(4.2342f, 122.2342f);

    //Func(12.12);

    //cout << GetNumber(4);

    //Func(123123, 12312);
    //cout << AreSymbolsEqual('Q', 'q') << endl;

    //cout << AreEqual(70, 21315) << endl;


    /*int num = 100;
    num = ChangeNumber(num);
    cout << num << endl;*/

    //cout << Pow(2.2, 6) << endl;

    //int code = GetSymbolCode('@');
    //cout << (char)code << endl;

    //cout << Func() << endl;
    //cout << Func(Func(15) + Func(Func(10) + 2));

    //cout << GetSymbolCode('@') << endl;




    //cout << Pow(5, 3) << endl;      // 125


}


/// 2D: f1rstStep87