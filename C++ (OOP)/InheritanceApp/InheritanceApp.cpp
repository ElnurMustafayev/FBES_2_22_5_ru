#include <iostream>
#include <map>

#include "Animals.h"

using namespace std;

class A {
protected:
	int numA = 111;
};

class B : public A {
protected:
	int numB = 222;

	void Func() {
		
	}
};

class C : public B {
	C()
	{
		this->numA = 123;
		this->numB = 123;
		this->Func();
	}
};


struct Parent {
	int PublicField;
	void PublicMethod() {}

protected:
	int ProtectedField;
	void ProtectedMethod() {}

private:
	int PrivateField;
	void PrivateMethod() {}
};

class Child : public Parent {
public:
	Child() {
		this->PublicField;
		this->PublicMethod();

		this->ProtectedField;
		this->ProtectedMethod();
	}
};

int main()
{
	Child child = Child();
	child.PublicField;
	child.PublicMethod();


	// struct A {
	// public field, Func
	// protected field, Func
	// private field, Func
	// }
	// 
	// class B : public A { }




	/*
	
		B b = B();
		cout << (b.Func() + 10);
	
	*/









	/*Cat cat = Cat();
	cat.name = "Rijik";

	cout << cat.name << endl;
	cat.AskFood();*/

	//Cat cat = Cat();
}