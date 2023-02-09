#pragma once

#include <iostream>

using namespace std;

enum Currencies {
    azn, euro, usd, rub
};
string CurrenciesStr[4]{ "azn", "euro", "usd", "rub", };
enum CardTypes {
    visa, mastercard
};
string CardTypesStr[4]{ "visa", "mastercard", };

class BankCard {
    double balance = 0;
    int cashbackBalance = 0;
    string pan;
    string cvv;
    Currencies currency = Currencies::azn;
    CardTypes cardType = CardTypes::visa;
    bool is3DSecured = false;

    void ShowMaskedCvv() const {
        cout << "CVV: ";
        for (int i = 0; i < this->cvv.length(); i++)
        {
            cout << '*';
        }
        cout << endl;
    }

    void ShowMaskedPan() const {
        cout << "PAN: ";

        for (int i = 0; i < this->pan.length(); i++)
        {
            cout << (i < 4 ? this->pan[i] : '*');

            if ((i + 1) % 4 == 0)
                cout << ' ';
        }

        cout << endl;
    }

public:
    BankCard(string pan, string cvv) {
        this->pan = pan;
        this->cvv = cvv;
    }

    void AddMoney(const double moneyToAdd) {
        this->balance += moneyToAdd;
    }

    bool operator +=(double moneyToAdd) {
        if (moneyToAdd <= 0)
            return false;

        this->balance += moneyToAdd;
        return true;
    }

    bool operator -=(double moneyToRemove) {
        if (moneyToRemove <= 0)
            return false;

        this->balance -= moneyToRemove;
        return true;
    }

    void Info() const {
        cout << "Balance: " << this->balance << " " << CurrenciesStr[this->currency] << endl;
        cout << "Card type: " << CardTypesStr[this->cardType] << endl;

        cout << "- - - - - - - - - - - - -" << endl;

        this->ShowMaskedPan();
        this->ShowMaskedCvv();
    }
};