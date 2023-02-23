#pragma once

#include <iostream>
using namespace std;

enum Gender {
	male, female, unknown, other, none
};

// Base class
class Animal {
protected:
	string name;
	int age;
	Gender gender;

	Animal() {
		cout << "ANIMAL CTOR" << endl;
	}

	void Say() {
		cout << "meow" << endl;
	}
};

class Cat : public Animal {
public:
	bool isPet;

	Cat()
	{
		cout << "CAT CTOR" << endl;
	}

	void AskFood() {
		cout << "MEOOOOOOOOOW!" << endl;
	}
};

class Dog {
public:
	bool isPet;
	bool isTrained;
	bool isFighter;

	void GivePat() {
		cout << "giving pat..." << endl;
	}
};

class Fish {
public:
	bool isInSaltWater;

	void SinkInToilet() {
		cout << "Sinking..." << endl;
	}
};