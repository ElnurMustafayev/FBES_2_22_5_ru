#include <iostream>

using namespace std;

//template<typename TForA>
//class A {
//public:
//	TForA num;
//};
//
//template<typename TForB>
//class B : public A<TForB> {
//public:
//	B() {
//		this->num = 132;
//	}
//};

#pragma region FIRST PROBLEM

class A1 {
public:
	int num;

	A1() : num(11) {}
};

class A2 {
public:
	int num;

	A2() : num(22) {}
};

class B1 : public A1, public A2 {
public:
	int num3;

	B1()
	{
		cout << "A1: " << this->A1::num << endl;
		cout << "A2: " << this->A2::num << endl;
	}
};

#pragma endregion

#pragma region DIAMOND PROBLEM

struct A {
	int num = 1;
};

struct B : public A {
	B()
	{
		this->num = 2;
	}
};

struct C : public A {
	C()
	{
		this->num = 3;
	}
};

struct D : public C, public B {
	D()
	{
		cout << this->A::num << endl;
		cout << this->B::num << endl;
		cout << this->C::num << endl;
	}
};

#pragma endregion



class HeroBase {
public:
	string name;
	string nickname;

	int attack = 10;
	int defence = 0;
	int hp = 100;
};

class HeroWithSuperPower {
public:
	int superPowerAttack;

	void SuperPower(HeroBase& hero) {
		hero.hp -= superPowerAttack;
	}
};

class Archer : public HeroBase {
public:
	int arrowsCount = 0;
};

class MortalCombatHero : public HeroBase, public HeroWithSuperPower {

};

struct Tekken : public HeroBase, public HeroWithSuperPower {

};

int main() {
	MortalCombatHero hero = MortalCombatHero();
	hero.name = "Scorpion";
	hero.nickname = "Bob777";
	hero.attack = 40;
	hero.defence = 30;
	hero.superPowerAttack = (hero.attack * 2);


	//D d = D();

	//B1 b = B1();
	//cout << b.A1::num << endl;

    //B<double> b = B<double>();
	//cout << sizeof(b) << endl;
}