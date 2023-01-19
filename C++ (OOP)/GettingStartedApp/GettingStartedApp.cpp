#include <iostream>

using namespace std;

struct Person {
public:
	char name[30];
	char surname[30];

private:
	int age;
	bool isMarried = false;
	double money;
};

class Animal {
	bool isPet;
public:
	char name[20];
	int age;
};

int main()
{
	/*
	Animal animal = Animal();
	strcpy_s(animal.name, "Rijik");
	animal.age = 18;
	*/



	//Person p = Person();
	//p.name;
	//p.surname;

	/*
	Person p = Person();
	strcpy_s(p.name, "Bob");
	strcpy_s(p.surname, "Marley");
	p.age = 80;
	p.money = 123123.45;

	cout << sizeof(Person) << endl;
	*/
}