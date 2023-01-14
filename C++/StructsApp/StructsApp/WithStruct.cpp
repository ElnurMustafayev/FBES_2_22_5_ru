#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;

enum Genders : int {
	male, female, other
};

struct Test {
	int num;
	char symbol;
};

struct MyStruct {
	int* ptr;
	int arr[10];
	Test test;
	Genders genders = Genders::other;
};

struct Person {
	char name[30]{};
	int age;
	Genders gender = Genders::other;
};

const char* GetGenderStr(Genders gender) {
	switch (gender)
	{
	case male:
		return "male";
	case female:
		return "female";
	case other:
		return "other";
	default:
		return "unknown";
	}
}

void PrintUser(char* name, int age, Genders gender) {
	cout << "Name: " << name << endl;
	cout << "Age: " << age << endl;
	cout << "Gender: " << GetGenderStr(gender) << endl;
}

void PrintUser(Person person) {
	cout << "Name: " << person.name << endl;
	cout << "Age: " << person.age << endl;
	cout << "Gender: " << GetGenderStr(person.gender) << endl;
}

void mainn() {
	Person person1 = Person();
	person1.age = 33;
	person1.gender = Genders::male;
	strcpy(person1.name, "Bob");

	Person person2 = Person();
	person2.age = 27;
	person2.gender = Genders::female;
	strcpy(person2.name, "Ann");

	Person person3 = Person();
	person3.age = 12;
	strcpy(person3.name, "Ted");

	Person people[3]{
		person1, person2, person3
	};

	for (size_t i = 0; i < 3; i++)
	{
		PrintUser(people[i]);
		cout << endl;
	}



	/*MyStruct obj1 = MyStruct();
	obj1.ptr = new int(111);

	MyStruct obj2 = MyStruct();
	obj2.ptr = obj1.ptr;

	*obj1.ptr += 39;
	obj1.ptr = new int(777);

	cout << *obj1.ptr << endl;
	cout << *obj2.ptr << endl;*/


	/*MyStruct obj1 = MyStruct();
	obj1.ptr = new int(123);

	MyStruct obj2 = MyStruct();
	obj2.ptr = obj1.ptr;

	*obj2.ptr += 10;

	cout << *obj1.ptr << endl;
	cout << *obj2.ptr << endl;*/







	/*Test obj1 = Test();
	obj1.num = 123;
	obj1.symbol = '$';

	cout << obj1.num << endl;
	cout << obj1.symbol << endl;

	Test obj2 = Test();
	cout << obj2.num << endl;
	cout << obj2.symbol << endl;*/







	//Test obj1 = Test();
	//Test obj2 = Test();

	//obj1.num = 10;
	//obj2.num = obj1.num;

	//obj2.num = 17;

	//cout << obj1.num << endl;	// 10
	//cout << obj2.num << endl;	// 17





	/*Test obj1 = Test();
	Test obj2 = Test();

	obj1.num = 111;
	obj2.num = 222;

	cout << &obj1 << ": " << obj1.num << endl;
	cout << &obj2 << ": " << obj2.num << endl;*/

	/*cout << &(obj1.num) << endl;
	cout << &(obj2.num) << endl;*/
}