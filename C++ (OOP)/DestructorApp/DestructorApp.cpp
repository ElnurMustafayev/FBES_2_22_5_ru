#include <iostream>

using namespace std;

//struct MyStruct {
//	static int num;
//
//	MyStruct()
//	{
//		cout << "CTOR" << endl;
//	}
//
//	~MyStruct() {
//		cout << "DTOR" << endl;
//	}
//
//	static void Method() {
//		cout << "METHOD" << endl;
//	}
//};
//int MyStruct::num = 123;


struct Task {
	char* title;
	int priority = 0;

	Task(char* title, int priority) : title(title), priority(priority) {}

	~Task() {
		cout << "DTOR for Task" << endl;

		if (this->title != nullptr) {
			delete[] this->title;
		}
		cout << "'title' filed deleted..." << endl;
	}
};



class Person {
public:
	const int adultYear;
	char* name;
	char* surname;
	Task* task;
	int age;

	Person() : adultYear(18) {}

	Person(char* name, char* surname, int age, Task* task) : age(age), adultYear(18), task(task) {
		cout << "CTOR" << endl;

		this->name = name;
		this->surname = surname;
	}

	void ShowInfo() {
		cout << "Name: " << this->name << endl;
		cout << "Surname: " << this->surname << endl;
		cout << "Age: " << this->age << endl;
	}

	~Person() {
		cout << "DTOR for Person" << endl;

		if (this->task != nullptr) {
			delete this->task;
		}
		cout << "'task' filed deleted..." << endl;
		if (this->name != nullptr) {
			delete[] this->name;
		}
		cout << "'name' filed deleted..." << endl;
		if (this->surname != nullptr) {
			delete[] this->surname;
		}
		cout << "'surname' filed deleted..." << endl;
	}
};

struct User {
	static int allCount;
	static int aliveCount;
	static int deathCount;

	User() {
		User::allCount++;
		User::aliveCount++;
	}

	~User() {
		User::aliveCount--;
		User::deathCount++;
	}
};

int User::allCount = 0;
int User::aliveCount = 0;
int User::deathCount = 0;

int main() {
	User u1 = User();
	{
		User u2 = User();
	}
	User* u3 = new User();
	User* u4 = new User();
	User* u5 = new User();
	delete u4;
	cout << User::allCount << endl;
	cout << User::aliveCount << endl;
	cout << User::deathCount << endl;





	/*char* taskTitle = new char[100] {'C', 'h', 'a', 'n', 'g', 'e', ' ', 'W', 'e', 'b', 's', 'i', 't', 'e'};
	Task* task = new Task(taskTitle, 4);

	Person* person = new Person();
	person->name = new char[30] { 'E', 'm', 'i', 'l' };
	person->surname = new char[30] { 'B', 'a', 'b', 'a', 'y', 'e', 'v', };
	person->age = 20;
	person->task = task;

	delete person;*/








	//while(true) {
	//	char* name = new char[30] { 'E', 'm', 'i', 'l' };
	//	char* surname = new char[30] { 'B','a','b','a','y','e','v', };
	//	/*Person p = Person(name, surname, 20);
	//	p.ShowInfo();*/
	//	Person* p = new Person(name, surname, 20);
	//	p->name = new char[30] { 'T', 'e', 's', 't' };
	//	p->surname = new char[30] { 'T', 'e', 's', 't' };
	//	p->ShowInfo();
	//	delete p;
	//}
	





	/*cout << "PROGRAM START" << endl;
	{
		MyStruct* obj = new MyStruct();
		obj->Method();

		delete obj;
		obj->~MyStruct();
	}
	cout << "PROGRAM END" << endl;*/



	/*cout << "PROGRAM START" << endl;
	{
		MyStruct obj = MyStruct();
		obj.Method();
	}
	cout << "PROGRAM END" << endl;*/
}