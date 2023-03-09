#include <iostream>

using namespace std;

class Person {
public:
	char* name;
	int age;

	Person(int age, char name[])
	{
		this->name = name;
		this->age = age;
	}

	Person(const Person& p)
	{
		memcpy(this, &p, sizeof(Person));
	}
};

class Test {
public:
	int num1;
	int* num2;

	double num3;
	float num4;
	int num5;

	Test() {
		cout << "DEFAULT CTOR" << endl;
	}

	Test(int num) : num1(num) {
		cout << "DEFAULT CTOR" << endl;
	}

	Test(const Test& obj)
	{
		cout << "COPY CTOR" << endl;

		//this->num1 = obj.num1;
		memcpy(this, &obj, sizeof(Test));

		//this->num2 = obj.num2;
		this->num2 = new int(*obj.num2);
	}

	Test operator = (const Test& obj) {
		cout << "operator =" << endl;

		return *this;
	}

	Test(Test&& obj) {
		cout << "MOVE CTOR" << endl;

		this->num2 = obj.num2;
	}

	~Test() {
		cout << "DTOR " << this->num1 << endl;
		//delete this->num2;
	}
};

void Func(Test t) {

}

Test FuncForMove() {
	Test t = Test(1);
	t.num2 = new int(123);
	cout << t.num2 << endl;
	return t;
}

Test CallDefaultCtor() {
	Test t = Test();
	cout << 2 + 2 << endl;;
	return Test();
}

int main()
{
	// MOVE CTOR
	if (false) {
		Test t1 = CallDefaultCtor();
		Test t2 = FuncForMove();
		cout << t2.num2 << endl;
	}

	// COPY CTOR
	if (false) {
		Test t1 = Test();
		t1.num1 = 123;

		Test t2;
		t2 = t1;
	}
	
	if (false) {
		char name[] = "Bob";
		Person p1 = Person(32, name);
		Person p2 = p1;

		cout << &p1.name << endl;
		cout << &p2.name << endl;
	}

	if (false) {
		Test obj1 = Test();
		obj1.num1 = 111;
		obj1.num2 = new int(111);

		Test obj2 = obj1;

		(*obj2.num2) += 10;

		cout << *obj1.num2 << endl;
		cout << *obj2.num2 << endl;
	}

	if (false) {
		Test obj1 = Test();
		obj1.num1 = 111;
		obj1.num2 = new int(111);

		{
			Test obj2 = obj1;
		}
	}

	if (false) {
		Test obj1 = Test();
		obj1.num1 = 111;
		obj1.num2 = new int(111);

		//Test obj2 = Test(obj1);
		//Test obj3 = Test(obj1);
		Func(obj1);
	}

	if (false) {
		int num1 = 100;
		int num2 = 0;

		memcpy(&num2, &num1, sizeof(int));

		cout << num1 << endl;
		cout << num2 << endl;
	}

	if (false) {
		Test obj1 = Test();
		obj1.num1 = 111;
		obj1.num2 = new int(111);

		Test obj2 = obj1;
		obj2.num1 += 10;
		(*obj1.num2) += 10;

		cout << obj1.num1 << endl;	// 111
		cout << obj2.num1 << endl;	// 121
		cout << endl;
		cout << *obj1.num2 << endl;	// 121
		cout << *obj2.num2 << endl;	// 121
	}
}