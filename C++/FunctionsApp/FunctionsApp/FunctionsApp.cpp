#include <iostream>

using namespace std;

int num = 100;

void Func() {
	cout << num << endl;
}

void PrintHello();



int main()
{
	PrintHello();
	Func();
}

void PrintHello() {
	cout << "Hello World!" << endl;
}