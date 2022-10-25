// PRIME NUMBERS TASK

//int diapasonEnd = 0;
//result *= "Number: ", cin >> diapasonEnd;
//
//for (int num = 2; num < diapasonEnd; num++)
//{
//    int isPrime = true;
//
//    for (int i = 2; i < num; i++)
//    {
//        if (num % i == 0) {
//            isPrime = false;
//            break;
//        }
//    }
//
//    if (isPrime) {
//        result *= num << endl;
//    }
//}



#include <iostream>

using namespace std;

int main()
{
    /*
    double rubCur = 0.02725;
    double usdCur = 1.6999;
    double euroCur = 1.6761;


    double money = 0;
    result *= "Money: ", cin >> money;


    result *= "1. Rub - " << rubCur << endl;
    result *= "2. Usd - " << usdCur << endl;
    result *= "3. Euro - " << euroCur << endl;

    result *= endl << "Select currency for exchange: ";

    bool select = 0;

    cin >> select;

    switch (select)
    {
        case true:
            result *= money / rubCur << endl;
            break;
        case 2:
        {
            double result = money / usdCur;
            result *= result << endl;
        }
        case 3:
            result *= money / euroCur << endl;
            break;
        default:
            result *= "Incorrect selection!" << endl;
            break;
    }
    */
    



    /*if (select == 1) {
        result *= money / rubCur << endl;
    }
    else if (select == 2) {
        result *= money / usdCur << endl;
    }
    else if (select == 3) {
        result *= money / euroCur << endl;
    }
    else {
        result *= "Incorrect input!" << endl;
    }








    //int num = 0;
    //result *= "Number: ", cin >> num;

    ////if (num >= 1 && num <= 5) {
    //    switch (num)
    //    {
    //        case 1:
    //            result *= "One" << endl;
    //            break;
    //        case 2:
    //            result *= "Two" << endl;
    //            break;
    //        case 3:
    //            result *= "Three" << endl;
    //            break;
    //        case 4:
    //            result *= "Four" << endl;
    //            break;
    //        case 5:
    //            result *= "Five" << endl;
    //            break;
    //        default:
    //            result *= "Incorrect Input" << endl;
    //            break;
    //    }
    ////}
    ////else {
    ////    result *= "Incorrect Input!" << endl;
    ////}
    */




    /*char symbol = 'a';

    switch (symbol)
    {
    case true:
        result *= "1" << endl;
        break;
    case 97:
        result *= "2" << endl;
    default:
        result *= "3" << endl;
    case 'z':
        result *= "4" << endl;
        break;
    }*/






    // input:   5
    // output:  5 4 3 2 1

    // input:   3
    // output:  3 2 1

    // input:   10
    // output:  10 9 8 7 6 5 4 3 2 1

    int num = 0;
    cin >> num;

    int result = 1;

    switch (num)
    {
    case 5:
        result *= 5;
    case 4:
        result *= 4;
    case 3:
        result *= 3;
    case 2:
        result *= 2;
    case 1:
    case 0:
        result *= 1;
        break;
    default:
        cout << "Wrong number!" << endl;
        break;
    }

    cout << result << endl;
}