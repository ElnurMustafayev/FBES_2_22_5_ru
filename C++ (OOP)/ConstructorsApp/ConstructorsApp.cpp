#include <iostream>
#include <vector>

using namespace std;

//int ProductsCount = 0;
int GetNumber(string message) {
	cout << message << endl;
	return rand();
}

struct MyType {
	int num;

	MyType() {
		cout << "CTOR" << endl;

		this->num = 777;
	}
};

class Person {
	string name;
	string surname;
	int age;

	void SetAge(int age) {
		this->age = age;
	}

public:
	int GetAge() {
		return this->age;
	}

	// parameterless
	Person() {
		cout << "parameterless ctor" << endl;

		this->name = "unknown";
		this->surname = "unknown";
		this->SetAge(-1);
	}

	// parametrized
	Person(string name, string surname, int age) {
		cout << "parametrized ctor 1" << endl;

		this->name = name;
		this->surname = surname;
		this->SetAge(age);
	}

	Person(string name, string surname) {
		cout << "parametrized ctor 2" << endl;

		this->name = name;
		this->surname = surname;
		this->SetAge(name.length() + surname.length());
	}

	void ShowInfo() {
		cout << "Name: " << this->name << endl;
		cout << "Surname: " << this->surname << endl;
		cout << "Age: " << this->GetAge() << endl;
	}
};

struct Product {
	string name = "unknown";
	double price = 0;

	Product() {
		//ProductsCount++;
		this->name = "parametrless";
	}

	Product(int) {
		//ProductsCount++;
		this->name = "parametrized";
	}

	Product(string) {
		//ProductsCount++;
	}
};

class MyClass {
public:
	int num1 = GetNumber("FIELD1");
	int num2 = GetNumber("FIELD2");

	template<typename T>
	MyClass(T obj)
	{
		cout << "CTOR" << endl;
	}
};

int main()
{
	/*MyClass obj1 = MyClass(123);
	MyClass obj2 = MyClass("qwe");

	cout << obj1.num1 << endl;
	cout << obj2.num2 << endl;*/



	/*cout << Product().name << endl;
	cout << Product(123).name << endl;
	cout << Product("qwerty").name << endl;*/


	/*int num = int(123);
	num = int(100);

	Person p = Person();
	p = Person("Sadiq", "Samadov", 17);*/


	/*Person().ShowInfo();
	Person("Sadiq", "Samadov", 17).ShowInfo();*/
	
	



	/*Person p1 = Person();
	p1.ShowInfo();*/

	/*Person p2 = Person();

	cout << "Name: " << Person().name << endl;
	cout << "Surname: " << Person().surname << endl;
	cout << "Age: " << Person().age << endl;*/



	/*MyType obj = MyType();
	cout << obj.num << endl;

	cout << MyType().num << endl;
	cout << MyType().num << endl;
	cout << MyType().num << endl;*/
}