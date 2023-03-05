#include <iostream>
#include "Animals.h"
#include "Guns.h"

using namespace std;

void AskAnimalToSay(Animal* animal) {
	animal->Say();
}

void Func(int) {
	cout << "INTEGER" << endl;
}

void Func(string) {
	cout << "STRING" << endl;
}


struct A {
	virtual int MyVirtualMethod(int num) {
		cout << "A: " << num << endl;

		return num;
	}
};

struct B : public A {
	virtual void Test(string arg1, double arg2) {
		cout << "B.Test()" << endl;
	}

	int MyVirtualMethod(int num) override {
		cout << "B: " << num << endl;

		return num + 1;
	}
};

struct C : public B {
	void Test(string arg1, double arg2) override {
		cout << "C.Test()" << endl;
	}

	int MyVirtualMethod(int num) override {
		cout << "C: " << num << endl;

		return num + 2;
	}
};

//void Func(Protocol* protocol) {
//	protocol->Start();
//	protocol->Send(100);
//	protocol->Stop();
//}


int main()
{
	//Func(new UDP());

	//A* a = new B();
	//a->MyVirtualMethod(10);


	//A* a = new B();
	//
	//int result = a->MyVirtualMethod(10);
	//
	//cout << result << endl;

	//Func(15);

	//Animal animal = Cat();
	//animal = Dog();
	//animal.Say();

	//Animal* animal = new Dog();
	//animal->Say();

	//Cat cat = Cat();
	//AskAnimalToSay(&cat);
	
	//Cat cat = Cat();
	//Animal* animal = &cat;
	//
	//animal->Say();

	/*Person person = Person();
	person.name = "Bob";

	Gun* gun = new Rpg();
	gun->Shot(person);

	cout << "Name: " << person.name << "\nHP: " << person.hp << endl;*/
}