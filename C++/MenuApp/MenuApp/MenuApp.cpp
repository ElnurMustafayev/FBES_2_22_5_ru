#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <conio.h>

using namespace std;

enum KEYBOARD_KEYS {
	up = 72,
	down = 80
};

int main()
{
	// system()
	/*
	char commandTxt[100]{};

	char ipTxt[16]{};

	cout << "IP: ", cin >> ipTxt;

	strcat(commandTxt, "ping ");
	strcat(commandTxt, ipTxt);

	system(commandTxt);

	system("ping 8.8.8.8");
	system("cls");
	*/


	





	const int menuLength = 5;
	int selectedIndex = 0;

	char menu[menuLength][50]{
		"Home",
		"Edit",
		"Delete",
		"About us",
		"Exit",
	};

	while (true) {
		// print
		system("cls");
		for (int i = 0; i < menuLength; i++)
		{
			if (i == selectedIndex) {
				cout << "> " << menu[i] << endl;
			}
			else {
				cout << menu[i] << endl;
			}
		}

		// input
		int key = _getch();

		// logic
		if (key == KEYBOARD_KEYS::up) {
			selectedIndex--;
		}
		else if (key == KEYBOARD_KEYS::down) {
			selectedIndex++;
		}
	}
}