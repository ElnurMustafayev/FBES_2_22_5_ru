#include <iostream>
#include "MyNamesapceLib.h"
#include <vector>

namespace MyNamespace {
	struct Car {
		const char* name;
		int age;
	};
}

using namespace std;
using namespace MyNamespace;
using namespace MyClasses;
using namespace MyNamespace::Test;

int main()
{
	cout << num << endl;
	//MyClasses::cout << "Test";

	MyNamespace::Person p1;
	MyClasses::Person p2;
}