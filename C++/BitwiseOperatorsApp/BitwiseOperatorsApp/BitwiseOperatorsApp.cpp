#include <iostream>

using namespace std;

int main()
{
    if (false) {
        int num1 = 10;

        int num2 = 14;

        // 00001010 = 10
        // &
        // 00001110 = 14
        // --------
        // 00001010 = 10
        cout << (num1 & num2) << endl;


        // 00001010 = 10
        // |
        // 00001110 = 14
        // --------
        // 00001110 = 14
        cout << (num1 | num2) << endl;


        // 00001010 = 10
        // ^
        // 00001110 = 14
        // --------
        // 00000100 = 4
        cout << (num1 ^ num2) << endl;


        // 00001010 = 10
        //          = -11
        cout << ~num1 << endl;


        // 00001110 = 14
        //          = -15
        cout << ~num2 << endl;


        // 00000000 00000000 00000000 00001110 = 15
        // 11111111 11111111 11111111 11110001 = -15
        // 255      255      255      241

        int num = -15;

        bool* stepper = (bool*)&num;

        cout << *(stepper) << endl;
        cout << *(stepper + 1) << endl;
        cout << *(stepper + 2) << endl;
        cout << *(stepper + 3) << endl;

        cout << num << endl;
    }
    



    /*char name[] = "Hello world!";

    for (int i = 0; i < strlen(name); i++)
    {
        char symbol = ~name[i];
        cout << (char)symbol;
    }*/


    char name[] = "Hello world!";

    cout << name << endl;
    char encrypted[20]{};

    // encrypt
    for (int i = 0; i < strlen(name); i++)
    {
        char symbol = (name[i] ^ i);
        encrypted[i] = symbol;
    }

    // print
    for (int i = 0; i < strlen(name); i++)
    {
        cout << encrypted[i];
    }
    cout << endl;

    // decrypt
    for (int i = 0; i < strlen(name); i++)
    {
        char symbol = (encrypted[i] ^ i);
        cout << symbol;
    }





    /*char number = 'a';

    char encryptedNumber = ~number;
    char decryptedNumber = ~encryptedNumber;

    cout << "Number: " << number << endl;
    cout << "Encrypted Number: " << encryptedNumber << endl;
    cout << "Decrypted Number: " << decryptedNumber << endl;*/
}