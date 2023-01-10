#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <conio.h>
#include "Functions.h"

using namespace std;

Bank bank = Bank();

void main() {
    FILE* bankStream = fopen("data\\bank.bin", "r");
    fread(&bank, sizeof(Bank), 1, bankStream);
    fclose(bankStream);

    FILE* usersStream = fopen("data\\users.bin", "r");
    int length = bank.usersCount;
    bank.usersCount = 0;
    bank.users = nullptr;
    for (int i = 0; i < length; i++)
    {
        Account* account = new Account();
        fread(account, sizeof(Account), 1, usersStream);
        AddUserInBank(bank, account);
    }
    fclose(usersStream);

    while (bank.currentAccount == nullptr) {
        system("cls");
        cout << "1 - Login" << endl;
        cout << "2 - Registration" << endl;
        int userSelect;
        cin >> userSelect;
        cin.ignore();

        try {
            if (userSelect == 1) {
                LoginMenu(bank);
            }
            else if (userSelect == 2) {
                Account* newAcc = RegistrationMenu();
                AddUserInBank(bank, newAcc);

                // save bank
                FILE* bankStream = fopen("data\\bank.bin", "w");
                fwrite(&bank, sizeof(Bank), 1, bankStream);
                fclose(bankStream);

                // save users
                FILE* usersStream = fopen("data\\users.bin", "a");
                fwrite(newAcc, sizeof(Account), 1, usersStream);
                fclose(usersStream);
            }
        }
        catch (const char* message) {
            cout << message << endl;
            _getch();
        }
    }






    

    /*
        Console APP: StepBank

        Bank
            int usersCount
            Users[]

        Account
            bool isBlocked
            char* nickname
            char* password
            Cards[]

        Card
            double balance
            enum type
            enum currency

        Product
            char* name
            double price
            enum type

        1. registration
        2. sign in
    */
}