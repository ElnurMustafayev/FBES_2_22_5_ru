#include <iostream>

using namespace std;

//void Func(int num1, int num2) {
//	if (num2 == 0)
//		throw 0;
//
//	cout << "Result: " << (num1 / num2) << endl;
//}

const int length = 7;
char symbols[length] = {
	'a',
	'b',
	'a',
	'Z',
	'Q',
	'D',
	'p',
};

int GetIndexByValue(char value) {
	for (int i = 0; i < length; i++)
		if (symbols[i] == value)
			return i;

	throw 404;
}

char GetValueByIndex(int index) {
	if (index < 0 || index >= length)
		throw 400;

	return symbols[index];
}

int main()
{
	try {
		throw 2.2;

		cout << GetIndexByValue('a') << endl;
		cout << GetValueByIndex(10) << endl;
	}
	catch (int errorCode) {
		if (errorCode == 404) {
			cout << "Not Found!" << endl;
		}
		else if (errorCode == 400) {
			cout << "Bad Request!" << endl;
		}

		cout << "Error: " << errorCode << endl;
	}
	catch (double) {
		cout << "Catch for double" << endl;
	}




	/*cout << "Start" << endl;
	try {
		cout << "Start try" << endl;
		throw 123.24f;
		cout << "End try" << endl;
	}
	catch (float code) {
		cout << "Error..." << endl;
		cout << "Code (float): " << code << endl;
	}
	catch (double code) {
		cout << "Error..." << endl;
		cout << "Code (double): " << code << endl;
	}
	cout << "End" << endl;*/




	/*int num1, num2;
	cin >> num1 >> num2;

	try {
		if (num2 == 0)
			throw num1++;

		cout << "Result: " << (num1 / num2) << "." << endl;
	}
	catch (int code) {
		cout << "Error with code " << code << endl;
	
		cout << code << endl;
		cout << num1 << endl;
	}*/



	//while (true) {
	//	int num1, num2;
	//	cin >> num1 >> num2;
	//	try {
	//		Func(num1, num2);
	//		break;
	//	}
	//	catch (int code) {
	//		cout << "Error: " << code << endl;
	//	}
	//}




}