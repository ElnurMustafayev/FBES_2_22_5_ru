#pragma once

double currencyRates[]{
    1, 1.7, 1.6
};
enum CURRENCIES {
    azn,
    usd,
    euro
};
enum CARD_TYPES {
    credit, debet
};
enum PRODUCT_TYPES {
    food, dairy, sport
};

struct Card {
    double balance;
    CARD_TYPES type;
    CURRENCIES currency;
};

struct Account {
    char nickname[50]{};
    char password[50]{};
    Card* cards;
    bool isBlocked = false;
};

struct Product {
    char name[30]{};
    double price;
    PRODUCT_TYPES type;
};

struct Bank {
    int usersCount;
    Account** users;
    Account* currentAccount;
};