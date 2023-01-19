#include <iostream>

using namespace std;

class Person {
private:
	char login[20];
	char password[20];

public:
	void Method() {
		Person p = Person();
		strcpy_s(p.login, "qwerty");
		strcpy_s(p.password, "Secert12345");
	}

	template<typename T>
	void TemplateMethod(T num) {
		cout << sizeof(T) << endl;
	}

	int ReturnRandomNumber() {
		srand(time(0));
		return rand();
	}
};

int main()
{
	Person p = Person();
	p.Method();

	int result = p.ReturnRandomNumber();
	//p.TemplateMethod("qwerty");
	//p.TemplateMethod(123);
}