#pragma once

#define _CRT_SECURE_NO_WARNINGS

#include "KEYBOARD_KEYS.h"

#include <iostream>
#include <conio.h>
#include <windows.h>

using namespace std;



HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);
int selectedIndex = 0;
const int menuLength = 5;

char menu[menuLength][50]{
		"Sum",
		"Minus",
		"Mult",
		"Div",
		"Exit",
};

int colors[menuLength]{
		0x70,
		0x19,
		0xA7,
		0xF1,
		0x23,
};



void PrintMenu() {
	system("cls");
	for (int i = 0; i < menuLength; i++)
	{
		if (i == selectedIndex) {
			SetConsoleTextAttribute(console, colors[i]);
			cout << "> " << menu[i] << endl;
			SetConsoleTextAttribute(console, 0x07);
		}
		else {
			cout << menu[i] << endl;
		}
	}
}



// returns true for close menu
bool Logic(int key) {
	switch (key)
	{
	case up:
		if (selectedIndex > 0)
			selectedIndex--;
		else if (selectedIndex == 0)
			selectedIndex = menuLength - 1;
		break;

	case down:
		if (selectedIndex < menuLength - 1)
			selectedIndex++;
		else if (selectedIndex == menuLength - 1)
			selectedIndex = 0;
		break;

	case enter:
		system("cls");

		// Sum
		if (selectedIndex == 0) {
			cout << "Sum page..." << endl;

			int num1, num2;
			cout << "Num 1: ", cin >> num1;
			cout << "Num 2: ", cin >> num2;

			cout << "Result: " << num1 + num2 << endl;

			_getch();
		}
		// Minus
		else if (selectedIndex == 1) {
			cout << "Minus page..." << endl;

			int num1, num2;
			cout << "Num 1: ", cin >> num1;
			cout << "Num 2: ", cin >> num2;

			cout << "Result: " << num1 - num2 << endl;

			_getch();
		}
		// Mult
		else if (selectedIndex == 2) {
			cout << "Mult page..." << endl;

			int num1, num2;
			cout << "Num 1: ", cin >> num1;
			cout << "Num 2: ", cin >> num2;

			cout << "Result: " << num1 * num2 << endl;

			_getch();
		}
		// Div us
		else if (selectedIndex == 3) {
			cout << "Div page..." << endl;

			int num1, num2;
			cout << "Num 1: ", cin >> num1;
			cout << "Num 2: ", cin >> num2;

			cout << "Result: " << num1 / num2 << endl;

			_getch();
		}
		// Exit
		else if (selectedIndex == 4) {
			return true;
		}

		break;

	case esc:
		system("cls");
		return true;
	}

	return false;
}