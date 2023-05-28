#include <iostream>
#include <vector>

using namespace std;

int GetNumber() {
    return 0;
}

void SayHello() {
    cout << "Hello World!" << endl;
}

void SayGoodbye() {
    cout << "Goodbye World!" << endl;
}

void Say(string message) {
    cout << "Message: " << message << endl;
}

int Minus(string str1, string str2) {
    return str1.length() - str2.length();
}

bool IsPositive(int number) {
    return number > 0;
}

bool IsNegative(int number) {
    return number < 0;
}

void Func(bool(*funcPtr)(int num)) {
    cout << "Result: " << funcPtr(10) << endl;
}

void Func(int num, bool(*funcPtr)(int num)) {
    cout << "Result: " << funcPtr(num) << endl;
}

vector<int> Func(vector<int> nums, bool(*funcPtr)(int num)) {
    vector<int> result = vector<int>();

    for (int num : nums) {
        if (funcPtr(num))
            result.push_back(num);
    }

    return result;
}


class User {
public:
    string Name;
    int Age;

    User(string name, int age) {
        this->Name = name;
        this->Age = age;
    }
};

bool IsAdult(User user) {
    return user.Age >= 18;
}

bool IsLongName(User user) {
    return user.Name.length() > 3;
}

vector<User> Filter(vector<User> users, bool(*filterFunc)(User user)) {
    vector<User> result = vector<User>();

    for (User user : users) {
        if (filterFunc(user) == true)
            result.push_back(user);
    }

    return result;
}

int main() {
    vector<User> users = vector<User>();

    users.push_back(User("Bob", 35));
    users.push_back(User("Ann", 7));
    users.push_back(User("Jane", 15));
    users.push_back(User("Alex", 25));
    users.push_back(User("Kate", 24));

    cout << "BEFORE: " << endl;
    for (User user : users)
    {
        cout << user.Name << " " << user.Age << endl;
    }

    //bool(*funcPtr)(User user) = IsAdult;
    //vector<User> result = Filter(users, funcPtr);
    vector<User> result = Filter(users, IsLongName);

    cout << endl << "AFTER: " << endl;
    for (User user : result)
    {
        cout << user.Name << " " << user.Age << endl;
    }





    //Func(IsNegative);
    //Func(-15, IsPositive);

    /*vector<int> nums = {
        12,-2,35,46,-67,0,12,0
    };

    cout << "BEFORE: " << endl;
    for (auto item : nums)
        cout << item << endl;

    vector<int> result = Func(nums, IsNegative);

    cout << "AFTER: " << endl;
    for (auto item : result)
        cout << item << endl;*/



    /*int(*funcPtr)(string str1, string str2) = Minus;
    auto result = funcPtr("qwerty", "123");
    cout << result << endl;*/

    /*bool(*checkNumberFunc)(int num) = IsPositive;
    
    auto result = checkNumberFunc(15);
    cout << result << endl;*/

    /*void(*funcPtr)(string message) = Say;
    funcPtr("one");
    funcPtr("two");
    funcPtr("three");*/


    /*void(*funcPtr1)() = SayHello;
    funcPtr1 = SayGoodbye;*/


    //void(*funcPtr2)(string message) = Say;


    //cout << GetNumber() << endl;
    //cout << GetNumber << endl;

    //int* funcPtr = GetNumber;


    /*int num = 123;

    int* numPtr = &num;

    cout << numPtr << endl;
    cout << *numPtr << endl;*/
}