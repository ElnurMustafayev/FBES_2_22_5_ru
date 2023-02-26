#include <iostream>
#include <set>
#include <map>
#include <stack>
#include <queue>

using namespace std;

class User {
	static int idCounter;

public:
	int id;
	string name;
	string email;
	int age;

	User(string email, string name, int age) : name(name), age(age), email(email) {}
	User(string name, int age) : name(name), age(age) {
		this->id = idCounter++;
	}
};

int User::idCounter = 1;

ostream& operator << (ostream & out, User user) {
	out << user.email << ": " << user.name << " " << user.age << " years old." << endl;
	return out;
}

void InitAndAddUserInMap(map<int, User>& users) {
	string name;
	cout << "Name: ", cin >> name;
	int age;
	cout << "Age: ", cin >> age;

	User newUser = User(name, age);

	users.insert(pair<int, User>(newUser.id, newUser));
}

struct Operation {
	string name;

	Operation(string name) : name(name) {}

	void Do() {
		cout << name << " is working..." << endl;

		if (rand() % 3 == 0)
			throw 400;
	}
};

int main()
{
	// map<int, string> col = map<int, string>();
    // col[1] = "One";
    // col[2] = "Two";
    // col.insert(pair<int, string>(3, "Three"));
    // //cout << (col[2]) << endl;

	// // delete el
    // col.erase(2);
    // col.erase(1);

    // for (auto item : col) {
    //     cout << (item.first) << " - " << (item.second) << endl;
    // }

	/*set<int> nums = set<int>();

	nums.insert(17);
	nums.insert(5);
	nums.insert(55);
	nums.insert(80);
	nums.insert(0);
	nums.insert(71);

	for (int num : nums) {
		cout << num << endl;
	}*/

	/*set<string> names = set<string>();

	names.insert("Elnur");
	names.insert("Tarana");
	names.insert("Aydin");
	names.insert("qwertyZ");
	names.insert("qwertyz");
	names.insert("Eldaniz");
	names.insert("Maxim");
	names.insert("Sadiq");
	names.insert("1a");
	names.insert("1b");

	for (auto name : names) {
		cout << name << endl;
	}*/

	/*set<User> users = set<User>();

	auto user1 = User("Test1", 11);
	auto user2 = User("Test2", 12);
	auto user3 = User("Test3", 13);

	users.insert(user1);
	users.insert(user2);
	users.insert(user3);

	for (auto user : users) {
		cout << user.name << endl;
	}*/



	// <TKey, TValue>
	/*map<int, string> dict = map<int, string>();

	pair<int, string> pair2 = pair<int, string>(3, "bbb");
	pair<int, string> pair1 = pair<int, string>(1, "aaa");
	pair<int, string> pair3 = pair<int, string>(5, "ccc");

	dict.insert(pair1);
	dict.insert(pair2);
	dict.insert(pair3);

	for (auto item : dict) {
		cout << item.first << " - " << item.second << endl;
	}*/

	// TKEY
	/*map<string, User> dict = map<string, User>();

	User user1 = User("bobmarley@gmail.com", "Bob", 56);
	User user2 = User("ann777@mail.ru", "Ann", 30);
	User user3 = User("victor@itstep.edu.az", "Victor", 28);

	dict.insert(pair<string, User>(user1.email, user1));
	dict.insert(pair<string, User>(user2.email, user2));
	dict.insert(pair<string, User>(user3.email, user3));

	for (auto keyValuePair : dict) {
		cout << keyValuePair.first << " - " << keyValuePair.second << endl;
	}*/



	//collection of people
	//key: Id

	/*map<int, User> dict = map<int, User>();

	InitAndAddUserInMap(dict);
	InitAndAddUserInMap(dict);
	InitAndAddUserInMap(dict);*/

	/*User user1 = User("Bob", 56);
	User user2 = User("Ann", 30);
	User user3 = User("Victor", 28);

	dict.insert(pair<int, User>(user1.id, user1));
	dict.insert(pair<int, User>(user2.id, user2));
	dict.insert(pair<int, User>(user3.id, user3));*/

	/*for (auto keyValuePair : dict) {
		cout << keyValuePair.first << " - " << keyValuePair.second << endl;
	}*/

	// Stack, Queue

	//FILO

	//stack<int> nums = stack<int>();
	//nums.push(11);
	//nums.push(22);
	//nums.push(33);
	//nums.push(44);

	////nums.pop();

	//cout << nums.top() << endl;
	//nums.pop();
	//cout << nums.top() << endl;
	//cout << nums.top() << endl;
	//nums.pop();
	//nums.pop();
	//cout << nums.top() << endl;

	/*srand(time(0));

	stack<Operation> operations = stack<Operation>();
	operations.push(Operation("Wake up!"));
	operations.push(Operation("Feed the cat!"));
	operations.push(Operation("Go to work!"));
	operations.push(Operation("Work hard!"));
	operations.push(Operation("Go to Step!"));
	operations.push(Operation("Go home!"));
	operations.push(Operation("Feed the cat!"));
	operations.push(Operation("Go to sleep!"));*/

	// Do() : cout << name << " is working..." << endl;
	
//start:
//	try {
//		int length = operations.size();
//		for (int i = 0; i < length; i++)
//		{
//			auto operation = operations.top();
//			operation.Do();
//			operations.pop();
//		}
//	}
//	catch (int errorCode) {
//		cout << "Operation " << operations.top().name << " returned error: " << errorCode << endl;
//		operations.pop();
//		goto start;
//	}

	//queue<int> nums = queue<int>();
	//nums.push(11);
	//nums.push(22);
	//nums.push(33);

	////FIFO
	//nums.pop();
	//cout << nums.front() << endl;
	//cout << nums.back() << endl;
}