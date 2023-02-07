#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;

#include "Datetime.h"
#include "User.h"


int main()
{
	User user1 = User("Elnur", "Abishev", Datetime(2003, 6, 7));
	User user2 = User("Eldaniz", "Yolchuyev", Datetime(2004, 1, 30));
	cout << user1.GetAge() << endl;
	cout << user2.GetAge() << endl;



	/*try {
		Datetime datetime = Datetime(1988, 2, 29);
	}
	catch (const char* message) {
		cout << "Error: " << message << endl;
	}*/
}