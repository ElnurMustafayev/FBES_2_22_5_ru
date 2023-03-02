#include <iostream>

using namespace std;

struct A {
public:
	int num1 = 1;
protected:
	int num2 = 2;
private:
	int num3 = 3;
};

struct B : public A {
	int num4 = 4;
public:
	B()
	{
	}
};

struct C : B {

};

int main()
{

}