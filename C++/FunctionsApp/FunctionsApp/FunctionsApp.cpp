#include <iostream>

using namespace std;

//void Sum() {
//	int num1, num2;
//
//	cout << "Number 1: ", cin >> num1;
//	cout << "Number 2: ", cin >> num2;
//
//	cout << (num1 + num2) << endl;
//}


void Sum(int num1, int num2) {
	cout << (num1 + num2) << endl;
}


void PrintNumbers(int count) {
	while (count) {
		cout << count-- << endl;
	}
}

void PrintAlphabet(int count, bool upRegister, char endLineSymbol = '\n');

void Test() {
	cout << "Start" << endl;
	for (int i = 0; i < 100; i+=2)
	{
		cout << i << endl;
		if (i == 12)
			return;
	}
	cout << "End" << endl;
}

int main()
{

	Test();



	//Sum();




	/*int num1, num2;

	cout << "Number 1: ", cin >> num1;
	cout << "Number 2: ", cin >> num2;

	Sum(num1, num2);
	Sum(num1, 10);
	Sum(13, 5);*/



	//PrintNumbers(5);





	//PrintAlphabet(3, true);		// A, B, C
	//cout << endl;
	//PrintAlphabet(4, false);	// a, b, c, d
	//cout << endl;
	//PrintAlphabet(-5, true);	// error
	//PrintAlphabet(0, false);	// error
	//
	//PrintAlphabet(30, true);	// error
	//PrintAlphabet(30, false);	// A - Z
	

	/*PrintAlphabet(3, true, '\t');
	PrintAlphabet(3, true, '\n');
	PrintAlphabet(3, true, '*');*/
}


void PrintAlphabet(int count, bool upRegister, char endLineSymbol) {
	if (count <= 0) {
		cout << "Error!" << endLineSymbol;
		return;
	}

	char startLetter = upRegister ? 'A' : 'a';
	count = (count > 26 ? 26 : count);

	for (int i = 0; i < count; i++)
	{
		char currentLetter = startLetter + i;
		char endSymbol = (count - i - 1) ? ',' : endLineSymbol;
		cout << currentLetter << endSymbol;
	}
}