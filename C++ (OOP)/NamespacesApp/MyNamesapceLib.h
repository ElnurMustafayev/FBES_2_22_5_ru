#pragma once


namespace MyNamespace {

	namespace Test {
		int num = 123;
	}

	const double PI = 3.14159;

	enum STATUSES {
		success, warning, error
	};

	struct Person {
		const char* name;
		int age;
	};

	void ShowPerson(Person p) {
		
	}
}


namespace MyClasses {
	//using namespace std;
	//using namespace MyNamespace;
	//using namespace MyNamespace::Test;

	class Person {
		std::string name;
		int age;
	};
}