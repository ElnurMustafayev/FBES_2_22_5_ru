#include <iostream>
#include <conio.h>
#include <windows.h>

using namespace std;

#include "MenuFunctions.h"

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



//	cout << "One" << endl;
//
//x2:
//	while (true) {
//		goto x1;
//		cout << "Two" << endl;
//	}
//
//x1:
//	goto x2;
//
//	cout << "Three" << endl;
	
	
	

	

	

	



	bool end = false;
	while (end == false) {
		// print
		PrintMenu();

		// input
		int key = _getch();

		// logic
		if (Logic(key))
			break;
	}

	cout << "Goodbye!" << endl;
}