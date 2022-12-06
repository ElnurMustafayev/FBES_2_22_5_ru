#include <iostream>
#include <conio.h>
#include "Functions.h"

using namespace std;

int main() {
	int loginLimit = 3;
	int step = 0;

	/*
	// login
	while (true) {
		try {
			if (!--loginLimit) {
				cout << "Access denied!" << endl;
				exit(0);
			}

			Login(&step);
			break;
		}
		catch (const char* errorMessage) {
			cout << "Error: " << errorMessage << endl;
			_getch();
		}
	}
	*/

	// setting
	srand(time(0));

	// initializing
	InitArea();

	InitCharacter(&heroY, &heroX, GameElements::hero);
	InitCharacter(&enemyY, &enemyX, GameElements::enemy);

	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);

	// stuff
	while (true) {
		// print
		DrawArea();

		// event
		int key = Input();

		// logic
		Logic(key);
	}
}