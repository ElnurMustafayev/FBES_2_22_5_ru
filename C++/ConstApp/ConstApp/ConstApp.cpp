#include <iostream>

using namespace std;

//int num = 100;
const double pi = 3.14;

int main()
{
	//const double pi = 3.14;

	//cout << pi << endl;

	//bool result = pi - 5;

	///*pi = 4;
	//pi += 1;
	//pi--;*/

	//cout << pi << endl;

	/*double radius;
	cout << "Radius (sm): ", cin >> radius;

	double result = 2 * (pi * radius);

	cout << "Dlina okrujnosti: " << result << endl;*/




	/*int age;
	const int adultAge = 18;

	cout << "Age: ", cin >> age;

	if (age >= adultAge) {
		cout << "OK" << endl;
	}
	else {
		cout << "Access denied!" << "User's age can not be less than " << adultAge << endl;
	}*/




	//int num;

	//cin >> num;

	//const int constNum = num;

	//num++;

	//cout << constNum << endl;


	/*do {

	} while (true);*/

	const int successLogin = 123, successPassword = 321;
	const int maxInputLimit = 3;

	for (int i = 0, login = 0, password = 0; !(login == successLogin && password == successPassword) && i < maxInputLimit; i++)
	{
		cout << "login: ", cin >> login;
		cout << "password: ", cin >> password;
	}
}