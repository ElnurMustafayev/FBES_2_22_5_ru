#include <iostream>

using namespace std;

class Person
{
	string name;
	int age;
	mutable int showedCounter = 0;
public:
	/*
	void ConstMethod() const {
		this->ChangeAge1(); // error
		this->ChangeAge2();	// ok
	}

	void ChangeAge1() {
		this->age = 123;
	}
	void ChangeAge2() const {

	}
	*/



	Person(string name, int age) {
		this->name = name;
		this->SetAge(age);
	}

	void ShowInfo() const {
		cout << "Name: " << this->name << endl;
		cout << "Age: " << this->age << endl;
		this->showedCounter++;
	}

	int GetShowedCounter() const {
		return this->showedCounter;
	}

	int GetAge() const {
		return this->age;
	}

	void SetAge(int age) {
		this->age = age;
	}
};

int main()
{
	Person p = Person("Bob", 45);
	cout << p.GetAge() << endl;
	p.ShowInfo();
	p.ShowInfo();
	p.ShowInfo();
	p.ShowInfo();
	p.ShowInfo();

	cout << "Showed " << p.GetShowedCounter() << " times" << endl;
}