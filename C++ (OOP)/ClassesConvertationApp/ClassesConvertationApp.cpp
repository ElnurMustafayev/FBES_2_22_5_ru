#include <iostream>
#include <vector>
#include <Windows.h>

using namespace std;

struct A {
	int numA = 10;
};

struct B : A {
	int numB = 20;

	B()
	{
		numA = 20;
	}
};

struct C : B {
	int numC = 30;

	C() {
		numB = 30;
	}
};

void Func(A a) {
	cout << a.numA << endl;
}






class Task {
public:
	string title;
	string description;

	Task(string title, string description) : title(title), description(description) {}

	Task() {}
};

class ColoredTask : public Task {
public:
	int color = 0x07;

	ColoredTask(string title, string description, int color) : Task(title, description), color(color) {}
};

ostream& operator<< (ostream& out, Task task) {
	out << task.title << ": " << task.description << endl;

	return out;
}

ostream& operator<< (ostream& out, ColoredTask task) {
	HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);

	SetConsoleTextAttribute(console, task.color);
	out << task.title << ": " << task.description << endl;
	SetConsoleTextAttribute(console, 0x07);

	return out;
}

int main()
{
	//Task task = Task("Title", "Description");

	//task = ColoredTask("Colored", "Task", 0x28);

	//cout << "Simple Task: " << task << endl;
	//cout << "Colored Task: " << coloredTask << endl;


	//A arr[] = {
	//	A(),		// numA = 10
	//	B(),		// numA = 20, numB = 20
	//	C(),		// numA = 20, numB = 30, numc = 30
	//};

	//for (A item : arr) {
	//	cout << item.numA << endl;	// 10 20 20
	//}



	/*vector<B> collection = {
		C(),
		B(),
		B(),
		C(),
	};

	for (B item : collection) {
		cout << item.numA << endl;
		cout << item.numB << endl;
	}*/



	/*B b = B();
	A a = C();
	A arr[] = {
		B(),
		A(),
		a,
		C(),
		b,
	};

	for (auto item : arr) {
		cout << sizeof(item) << endl;
	}*/

	//Func(C());
	//Func(B());
}