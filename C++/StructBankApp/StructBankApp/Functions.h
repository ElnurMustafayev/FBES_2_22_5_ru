#pragma once

#include <iostream>
#include "Structs.h"

using namespace std;

Account* RegistrationMenu() {
	system("cls");

	Account* account = new Account();

	cout << "REGISTRATION" << "\n\n";
	cout << "Nickname: ", cin >> account->nickname;
	cout << "Password: ", cin >> account->password;

	return account;
}

void LoginMenu(Bank& bank) {
	system("cls");

	if (bank.usersCount == 0) {
		throw "There is no user in App!";
	}

	cout << "LOGIN" << "\n\n";

	char nickname[50]{};
	char password[50]{};

	cout << "Nickname: ", cin >> nickname;
	cout << "Password: ", cin >> password;

	for (int i = 0; i < bank.usersCount; i++)
	{
		bool areEqual = !strcmp(bank.users[i]->nickname, nickname) && !strcmp(bank.users[i]->password, password);

		if (areEqual) {
			bank.currentAccount = bank.users[i];
			return;
		}
	}

	throw "There is no user in App!";
}


void AddUserInBank(Bank& bank, Account* newUser) {
	Account** newAccounts = new Account*[bank.usersCount + 1];

	for (int i = 0; i < bank.usersCount; i++)
		newAccounts[i] = bank.users[i];

	newAccounts[bank.usersCount] = newUser;

	delete[] bank.users;

	bank.users = newAccounts;
	bank.usersCount++;
}