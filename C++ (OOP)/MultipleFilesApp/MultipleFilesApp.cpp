#include <iostream>
#include "User.h"
#include "String.h"
using namespace std;

int main()
{
	User<int> user = User<int>("Elnur", "Secret12345!");

	cout << user.Login("test", "qwerty") << endl;

	/*String str = "qwerty";
	cout << str.Length() << endl;
	cout << str.GetString() << endl;*/
}