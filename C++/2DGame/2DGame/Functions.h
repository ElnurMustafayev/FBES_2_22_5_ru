#pragma once

#include <iostream>
#include "Enums.h"

using namespace std;

const int areaWidth = 12;
const int areaHeight = 12;

int heroX = 0;
int heroY = 0;

int enemyX = 0;
int enemyY = 0;

int score = 0;

int area[areaHeight][areaWidth]{};

char name[20] = "Bob";
char surname[20] = "Marley";



void Login(int* step) {
	system("cls");

	// NAME
	if (*step < 1) {
		cout << "Name: ", cin >> name;
	}

	if (strlen(name) < 3) {

		throw "Name can not be less than 3!";
	}
	*step = 1;



	// SURNAME
	if (*step < 2) {
		cout << "Surname: ", cin >> surname;
	}

	if (strlen(surname) < 3) {

		throw "Surname can not be less than 3!";
	}
	*step = 2;
}


void InitArea() {
	for (int y = 0; y < areaHeight; y++)
	{
		for (int x = 0; x < areaWidth; x++)
		{
			if ((y == 0 || y == areaHeight - 1) || (x == 0 || x == areaWidth - 1))
				area[y][x] = 3;
		}
	}
}


void InitCharacter(int* characterY, int* characterX, GameElements whoIsIt) {
	// y: 0 - 10 -> [1, 8]
	// x: 0 - 10 -> [1, 8]
	do {
		*characterY = (rand() % (areaHeight - 2)) + 1;
		*characterX = (rand() % (areaWidth - 2)) + 1;
	} while (area[*characterY][*characterX] != 0);

	area[*characterY][*characterX] = whoIsIt;
}


void InitCharacter(GameElements whoIsIt) {
	// y: 0 - 10 -> [1, 8]
	// x: 0 - 10 -> [1, 8]
	int currentX = 0, currentY = 0;

	do {
		currentX = (rand() % (areaHeight - 2)) + 1;
		currentY = (rand() % (areaWidth - 2)) + 1;
	} while (area[currentY][currentX] != 0);

	area[currentY][currentX] = whoIsIt;
}



void PrintAreaElement(int elementNumber = GameElements::empty) {
	switch ((GameElements)elementNumber)
	{
	case GameElements::empty:
		cout << "  ";
		break;
	case GameElements::hero:
		cout << (char)1 << " ";
		break;
	case GameElements::enemy:
		cout << (char)2 << " ";
		break;
	case GameElements::fence:
		cout << (char)254 << " ";
		break;
	default:
		break;
	}
}



// draws area array
void DrawArea() {
	system("cls");

	cout << name << " " << surname << endl;
	cout << "Score: " << score << "\n\n";

	for (int y = 0; y < areaHeight; y++)
	{
		for (int x = 0; x < areaWidth; x++)
		{
			PrintAreaElement(area[y][x]);
			//// hero
			//if (y == heroY && x == heroX) {
			//	cout << 1 << ' ';
			//}

			//// enemy
			//else if (y == enemyY && x == enemyX) {
			//	cout << 2 << ' ';
			//}

			//else {
			//	cout << area[y][x] << ' ';
			//}
		}

		cout << endl;
	}
}


int Input() {
	int key;
	do {
		key = _getch();
	} while (key == 224);

	return key;
}


void Logic(int key) {
	area[heroY][heroX] = GameElements::empty;
	
	//switch (tolower(key))
	switch (key)
	{
	case KEYBOARD_KEYS::w:
	case KEYBOARD_KEYS::up:
		if (heroY > 0) {
			if (area[heroY - 1][heroX] != 3) {
				heroY--;
			}
		}
		break;

	case KEYBOARD_KEYS::s:
	case KEYBOARD_KEYS::down:
		if (heroY < areaHeight - 1) {
			if (area[heroY + 1][heroX] != 3) {
				heroY++;
			}
		}
		break;

	case KEYBOARD_KEYS::a:
	case KEYBOARD_KEYS::left:
		if (heroX > 0) {
			if (area[heroY][heroX - 1] != 3) {
				heroX--;
			}
		}
		break;

	case KEYBOARD_KEYS::d:
	case KEYBOARD_KEYS::right:
		if (heroX < areaWidth - 1) {
			if (area[heroY][heroX + 1] != 3) {
				heroX++;
			}
		}
		break;

	case KEYBOARD_KEYS::space:
		InitCharacter(&enemyY, &enemyX, GameElements::enemy);

		score += 100;

		if (score % 500 == 0) {
			for (size_t i = 0; i < 10; i++)
			{
				InitCharacter(GameElements::fence);
			}
		}
		else {
			InitCharacter(GameElements::fence);
		}
		break;
	}

	// hero is on enemy
	if (heroY == enemyY && heroX == enemyX) {
		InitCharacter(&enemyY, &enemyX, GameElements::enemy);

		score += 100;

		if (score % 500 == 0) {
			for (size_t i = 0; i < 10; i++)
			{
				InitCharacter(GameElements::fence);
			}
		}
		else {
			InitCharacter(GameElements::fence);
		}
	}

	area[heroY][heroX] = GameElements::hero;
}



















/// <summary>
/// draw 2D area
/// </summary>
/// <param name="area">area</param>
/// <param name="height">height</param>
/// <param name="width">width</param>
void DrawArea(int* area, int height, int width) {
	for (int y = 0; y < height; y++)
	{
		int* currentRow = (area + width * y);
		for (int x = 0; x < width; x++)
		{
			cout << *(currentRow + x) << ' ';
		}

		cout << endl;
	}
}