#include <iostream>

using namespace std;


void GetError(int num) {
    if (num >= 0) {
        throw "number is >= 0!";
    }
    else {
        throw "number is < 0!";
    }
}


void CheckAge(const int age) {
    //age = 12312312;
}


bool CheckName(const char* name) {
    //name[1] = 'u';

    if (name == nullptr)
        return false;
}



void PointerToConst(const int* ptr);
void ConstPointer(int* const ptr);
void ConstPointerToConst(const int* const ptr);

int _main()
{
    //char word[]{ "Test" };
    //const char* wordPtr = word;

    ///*
    //word[2] = 'Q';
    //wordPtr[2] = 'Q';
    //*/

    //cout << word << endl;


    /*int num = 100;
    const int* numPtr = &num;

    cout << *numPtr << endl;

    *numPtr = 123;*/

    /*
    //const int num = 100;
    // pointer to const
    const int* numPtr = &num;

    // ok
    cout << *numPtr << endl;

    // not ok
    *numPtr = 123123;
    */

    //const char* str = "qwerty";

    ////str[2] = 'Z';

    //cout << str << endl;



    /*try {
        GetError(100);
    }
    catch (char* errorMessage) {
        cout << errorMessage << endl;
    }
    catch (const char* errorMessage) {
        cout << errorMessage << endl;
    }*/


    /*char name[]{ "Bob" };

    cout << CheckName(name) << endl;
    cout << "Name: " << name << endl;*/







    /*int num = 123;
    int* const numPtr = &num;


    numPtr++;
    numPtr = numPtr;
    numPtr = &num;*/

    /*
    *numPtr = 777;

    cout << *numPtr << endl;
    cout << num << endl;
    */



}

void PointerToConst(const int* ptr) {
    // yes
    cout << *ptr << endl;
    cout << ptr[2] << endl;
    int num = 100;
    ptr = &num;

    // no
    //*ptr = 123;
    //ptr[2] = 123;
}


void ConstPointer(int* const ptr) {
    // yes
    *ptr = 123;
    ptr[2] = 123;
    cout << *ptr << endl;
    cout << ptr[2] << endl;

    // no
    //int num = 100;
    //ptr = &num;
}


void ConstPointerToConst(const int* const ptr) {
    // yes
    cout << *ptr << endl;
    cout << ptr[2] << endl;

    // no
    //*ptr = 123;
    //ptr[2] = 123;
    //int num = 100;
    //ptr = &num;
}