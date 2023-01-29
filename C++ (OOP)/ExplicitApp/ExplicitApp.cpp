#include <iostream>

using namespace std;

class Person {
	string name;
	int age = 0;

public:
	explicit Person(string name, int age) {
		cout << "PARAMETRIZED CTOR" << endl;
		this->name = name;
		this->age = age;
	}

	explicit Person(string name) {
		cout << "CTOR STRING" << endl;
		this->name = name;
		this->age = -1;
	}

	explicit Person(int age) {
		cout << "CTOR INT" << endl;
		this->age = age;
		this->name = "Unknown";
	}

	void ShowInfo() {
		cout << "Name: " << this->name << endl;
		cout << "Age: " << this->age << endl;
	}
};


struct Int {
	int value;

	Int(int value)
	{
		this->value = value;
	}

	bool isPositive() {
		return this->value >= 0;
	}
};


int main()
{
	/*Int num1 = 123;
	cout << num1.isPositive() << endl;*/


	string name = "Jane";

	//Person p1 = { "Bob", 45 }; //Person("Bob", 45);
	Person p2 = Person("Bob", 45);
	//Person p3 = string("Jane");
	//Person p4 = 25;
	//Person p5 = name;
	Person p6 = Person(name);
}