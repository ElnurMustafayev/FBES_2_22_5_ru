#include <iostream>
#include <map>
#include <conio.h>

using namespace std;

class Animal {
public:
	string name;

	/*virtual void Say() {
		cout << "Animal can not Say something!" << endl;
	}*/

	// At(int) {

	virtual void Say() = 0;
	virtual double GetHp() = 0;
};

class Cat : public Animal {
public:
	void Say() override {
		cout << "meow" << endl;
	}

	double GetHp() override {
		return 100;
	}
};

class Dog : public Animal {
public:
	void Say() override {
		cout << "huf" << endl;
	}

	double GetHp() override {
		return 150;
	}
};







class Fighter {
public:
	int attack;
	int defence;
	int hp;
	bool isAlive = true;

	Fighter(int attack, int defence, int hp = 100) :
		attack(attack),
		defence(defence),
		hp(hp) {}

	void ShowBasicInfo() {
		cout << "Attack: " << attack << endl;
		cout << "Defence: " << defence << endl;
		cout << "Hp: " << hp << endl;
	}

	virtual void Hit(Fighter* oponent) = 0;
};


class Boxer : public Fighter {
public:
	Boxer(int attack, int defence, int hp = 150) : Fighter(attack, defence, hp) {}

	void Hit(Fighter* oponent) override {
		if (oponent->isAlive == false)
			return;

		oponent->hp -= (this->attack * 2);

		if (oponent->hp <= 0) {
			oponent->isAlive = false;

			cout << "Knock-Out" << endl;
		}
	}
};


class KickBoxer : public Fighter {
public:
	KickBoxer(int attack, int defence, int hp = 80) : Fighter(attack, defence, hp) {}

	void Hit(Fighter* oponent) override {
		if (oponent->isAlive == false)
			return;

		for (int i = 0; i < 5; i++)
		{
			if(rand() % 3 != 0)
				oponent->hp -= this->attack;
		}

		if (oponent->hp <= 0) {
			oponent->isAlive = false;

			cout << "TKO" << endl;
		}
	}
};


class Wrestler : public Fighter {
public:
	Wrestler(int attack, int defence, int hp = 120) : Fighter(attack, defence, hp) {}

	void Hit(Fighter* oponent) override {
		if (oponent->isAlive == false)
			return;

		if (rand() % 3 == 0)
			oponent->hp -= this->attack;

		if (rand() % 8 == 0) {
			oponent->hp = 0;
			cout << "TakeDown!!!" << endl;
		}

		if (oponent->hp <= 0) {
			oponent->isAlive = false;

			cout << "KO" << endl;
		}
	}
};



int main()
{
	srand(time(0));

	Fighter* conor = new KickBoxer(5, 0);
	Fighter* khabib = new Wrestler(12, 0);

	while (conor->isAlive && khabib->isAlive) {
		system("cls");

		conor->Hit(khabib);
		khabib->Hit(conor);

		cout << "Conor: " << endl;
		conor->ShowBasicInfo();

		cout << "- - - - - - - - - -" << endl;

		cout << "Khabib: " << endl;
		khabib->ShowBasicInfo();

		_getch();
	}


	//Animal* animal = new Animal();

	/*Animal* animal = new Dog();
	double result = animal->GetHp();
	animal->Say();

	cout << result << endl;*/
}