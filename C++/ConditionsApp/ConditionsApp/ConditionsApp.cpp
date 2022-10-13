#include <iostream>

using namespace std;

int main()
{
	// global variable
	//bool check = false;

	//if (true) {
	//	// local variable
	//	int num = 100;

	//	cout << check << endl;
	//}

	//cout << num << endl;



	/*
	int age;
	cin >> age;
	bool success = false;

	if (age >= 18) {
		success = true;
	}

	cout << success << endl;
	*/




	/*
	int age = 5;

	cout << "Start" << endl;

	if (age >= 18)
		// test comment
		cout << "Adult!" << endl;
		cout << "Access OK!" << endl;

	cout << "End" << endl;
	*/
	




	/*if (10 > 5)
		int num = 100;

	cout << num << endl;*/


	/*int age;
	cin >> age;

	if (age >= 18) {
		cout << "Adult! Access OK!" << endl;
	}
	else if (age > 0 && age < 18) {
		cout << "Access denied!" << endl;
	}
	else {
		cout << "Incorect value for age!" << endl;
	}*/






	/*int age;
	cin >> age;
	if (age >= 18)
		cout << "Adult! Access OK!" << endl;
	else if (age > 0 && age < 18)
		cout << "Access denied!" << endl;
	else
		cout << "Incorect value for age!" << endl;*/




	/*if (false) {
		int one = 1;
	}
	else if (true) {
		int two = 1;
	}
	else {
		int three = 1;
		cout << three << endl;
	}*/



	//char symbol = 'W';

	//{
	//	cout << symbol << endl;
	//}







	// 0	-	1k		-> 1 level
	// 1k	-	5k		-> 2 level
	// 5k	-	10k		-> 3 level
	// 10k	-	50k		-> 4 level
	// 50k	-	inf		-> 5 level

	// negative -> show error message

	//double money;
	//int level = 0;
	//cout << "Input your money: ", cin >> money;

	//level = (money >= 0) 
	//	+ (money >= 1000) 
	//	+ (money >= 5000) 
	//	+ (money >= 10000) 
	//	+ (money >= 50000);

	///*if (money >= 0 && money < 1000) {
	//	level = 1;
	//}
	//else if (money >= 1000 && money < 5000) {
	//	level = 2;
	//}
	//else if (money >= 5000 && money < 10000) {
	//	level = 3;
	//}
	//else if (money >= 10000 && money < 50000) {
	//	level = 4;
	//}
	//else if (money >= 50000) {
	//	level = 5;
	//}
	//else {
	//	cout << "Incorrect money!" << endl;
	//}*/

	//cout << "User level: " << level << endl;
	

	//bool condition = true;

	////int result = condition ? 123 : 321;

	//int result;

	//if (condition) {
	//	result = 123;
	//}
	//else {
	//	result = 321;
	//}

	//cout << result << endl;
	

	

	/*int age = 5;

	int isAdult = age >= 18 ? 10 : 15;

	cout << isAdult << endl;*/






	/*
	false ? (cout << "OK") : (cout << "Exit");

	cout << (false ? "OK" : "Exit");
	*/


	//cout << (false ? 123 : "asdasd");



	int num = 100;

	if (true) {
		float temp = num;
		float num = temp;
		cout << num << endl;
	}

	cout << num << endl;
}