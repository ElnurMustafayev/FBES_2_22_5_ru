#pragma once

#include <iostream>
using namespace std;




// Person
//
//
// Weapon
//	|
//	|
// Gun	-----  ------
//	|		|		|
//	|		|		|
// Pistol  Automat  Rpg


struct Person {
	int hp = 100;
	string name;
};


struct Weapon { };

struct Gun : public Weapon {
	virtual void Shot(Person& person) {}
};

struct Pistol : public Gun {
	void Shot(Person& person) override {
		person.hp -= 10;
		cout << " - " << endl;
	}
};

struct Automat : public Gun {
	void Shot(Person& person) override {
		person.hp -= 30;
		cout << " - - - " << endl;
	}
};

struct Rpg : public Gun {
	void Shot(Person& person) override {
		person.hp = 0;
		cout << " *(B-O-O-M)* " << endl;
	}
};