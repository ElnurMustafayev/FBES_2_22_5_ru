#pragma once

#include <iostream>
using namespace std;

enum Gender {
	male, female, unknown, other, none
};

// Base class
class Animal {
public:
	string name;
	int age;
	Gender gender;

	virtual void Say() {
		cout << "Default Say" << endl;
	}

	void Fight() {

	}
};

class Cat : public Animal {
public:
	bool isPet;

	void Say() {
		cout << "meow" << endl;
	}

	void AskFood() {
		cout << "MEOOOOOOOOOW!" << endl;
	}
};

class Dog : public Animal {
public:
	bool isPet;
	bool isTrained;
	bool isFighter;

	void Say() {
		cout << "huf" << endl;
	}

	void GivePat() {
		cout << "giving pat..." << endl;
	}
};

class Fish : public Animal {
public:
	bool isInSaltWater;

	void Say() {
		cout << "..." << endl;
	}

	void SinkInToilet() {
		cout << "Sinking..." << endl;
	}
};