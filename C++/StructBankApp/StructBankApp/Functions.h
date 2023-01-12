#pragma once

#include <iostream>
#include <conio.h>
#include "Structs.h"

using namespace std;



// - - - - - ACCOUNT   FUNCTIONS - - - - -
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



template<typename T>
T** AddElement(T** oldArr, T* newElement, int& length) {
	T** newArr = new T*[length + 1];

	for (int i = 0; i < length; i++)
		newArr[i] = oldArr[i];

	newArr[length] = newElement;

	delete[] oldArr;

	length++;

	return newArr;
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



// - - - - - OTHER    FUNCTIONS - - - - - 
int SelectSection(const char** selections, int selectionsCount) {
	for (int i = 0; i < selectionsCount; i++)
	{
		cout << i + 1 << ". " << selections[i] << endl;
	}

	while (true) {
		int input;
		cin >> input;

		if (selectionsCount >= input && input >= 1)
			return input;
	}
}

template<typename TEnum>
TEnum AskEnum(const char* whatToSelect, int enumMin, int enumMax, const char** selections = nullptr) {
	cout << "Input value from " << enumMin << " to " << enumMax << endl;
	if (selections != nullptr) {
		for (int i = 0; i < (enumMax - enumMin + 1); i++)
		{
			cout << enumMin + i << " - " << selections[i] << endl;
		}
	}

	while (true) {
		int input;
		cout << "Select " << whatToSelect << ": ", cin >> input;

		if (enumMax >= input && input >= enumMin)
			return (TEnum)input;
	}
}

const char* GetName(const char** selections, int index) {
	return selections[index];
}




// - - - - - CARD   FUNCTIONS - - - - -
const char** currencyNames = new const char* [3] { "AZN", "USD", "EURO" };
const char** cardTypeNames = new const char* [2] { "CREDIT", "DEBET"};

void ShowCard(Card* card) {
	cout << card->balance << " " << GetName(currencyNames, card->currency - 1) << endl;
	cout << GetName(cardTypeNames, card->type - 1) << endl;
}

Card* OrderCardMenu() {
	system("cls");

	cout << "CARD ORDER MENU" << "\n\n";

	Card* newCard = new Card();
	newCard->currency = AskEnum<CURRENCIES>("Currency", CURRENCIES::azn, CURRENCIES::euro, currencyNames);
	newCard->type = AskEnum<CARD_TYPES>("Card Type", CARD_TYPES::credit, CARD_TYPES::debet, cardTypeNames);

	return newCard;
}










// - - - - - MENU   FUNCTIONS - - - - -
void CashInMenu(Account* currentAccount) {
	system("cls");

	if (currentAccount->cardsCount > 0 && currentAccount->cards != nullptr) {
		for (int i = 0; i < currentAccount->cardsCount; i++)
		{
			cout << i + 1 << " ";
			ShowCard(currentAccount->cards[i]);
			cout << endl;
		}
	}

	cout << "Select Card to Cash In: ";
	int input;
	cin >> input;

	Card* selectedCard = currentAccount->cards[input - 1];

	cout << "Input Cash: ";
	double cash;
	cin >> cash;

	selectedCard->balance += abs(cash);
}

void CardsMenu(Account* currentAccount) {
	while (true) {
		system("cls");

		int sectionsCount = 3;
		auto generalMenuSections = new const char* [sectionsCount] {
			"Info",
			"Order Card",
			"Exit"
		};
		int selection = SelectSection(generalMenuSections, sectionsCount);

		switch (selection)
		{
		case 1:
			// CARDS INFO
			system("cls");
			cout << "CARDS INFO" << "\n\n";

			if (currentAccount->cardsCount > 0 && currentAccount->cards != nullptr) {
				for (int i = 0; i < currentAccount->cardsCount; i++)
				{
					ShowCard(currentAccount->cards[i]);
					cout << endl;
				}
			}

			_getch();
			break;
		case 2: {
			Card* newCard = OrderCardMenu();
			currentAccount->cards = AddElement(currentAccount->cards, newCard, currentAccount->cardsCount);
			break;
		}
		case 3:
		default:
			return;
		}
	}
}



void GeneralMenu(Account* currentAccount) {
	while (true) {
		system("cls");

		int sectionsCount = 5;
		auto generalMenuSections = new const char* [sectionsCount] {
			"Cards",
			"Cash In",
			"Spend money",
			"History",
			"Exit"
		};
		int selection = SelectSection(generalMenuSections, sectionsCount);

		switch (selection)
		{
		case 1:
			CardsMenu(currentAccount);
			break;
		case 2:
			CashInMenu(currentAccount);
			break;
		case 3:
			break;
		case 4:
			break;

		case 5:
		default:
			return;
		}
	}
}


