#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <conio.h>
#include "Functions.h"

#define TEST

using namespace std;

Bank bank = Bank();

void main() {
    /*FILE* bankStream = fopen("data\\bank.bin", "r");
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
    fclose(usersStream);*/

#ifndef TEST
    // LOGIN / REGISTRATION
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

                //// save bank
                //FILE* bankStream = fopen("data\\bank.bin", "w");
                //fwrite(&bank, sizeof(Bank), 1, bankStream);
                //fclose(bankStream);

                //// save users
                //FILE* usersStream = fopen("data\\users.bin", "a");
                //fwrite(newAcc, sizeof(Account), 1, usersStream);
                //fclose(usersStream);
            }
        }
        catch (const char* message) {
            cout << message << endl;
            _getch();
        }
    }
#endif

#ifdef TEST
    Account* testAccount = new Account();
    strcpy_s(testAccount->nickname, "test");
    strcpy_s(testAccount->nickname, "test");

    bank.usersCount = 1;
    bank.users = new Account * [1] {
        testAccount
    };
    bank.currentAccount = testAccount;
#endif 

    // APPLICATION
    GeneralMenu(bank.currentAccount);
}