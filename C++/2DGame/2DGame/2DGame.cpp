#include <iostream>
#include <conio.h>
#include "Functions.h"

using namespace std;

int main() {
	srand(time(0));

	InitArea();
	InitCharacter(&heroY, &heroX, GameElements::hero);
	InitCharacter(&enemyY, &enemyX, GameElements::enemy);

	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);
	InitCharacter(GameElements::fence);

	while (true) {
		DrawArea();

		int key = Input();

		Logic(key);
	}
}