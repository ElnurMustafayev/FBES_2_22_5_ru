#include <iostream>

using namespace std;

int main()
{


	//// -9, -7, -5, -3, -1,

	//int condition = -10;
	//while (condition++) 
	//{
	//	cout << condition++ << endl;
	//}


	// input: 5
	// output: 5 4 3 2 1 0

	// input: -5
	// output: -5 -4 -3 -2 -1 0



	/*int num;
	cin >> num;

	while (num >= 0)
		cout << num-- << endl;*/




	// break, continue



	/*cout << "main Start" << endl;
	while (true) {
		cout << "while Start" << endl;
		break;
		cout << "while End" << endl;
	}
	cout << "main End" << endl;*/

	/*int x = 0, y = 0;

	while (true) {
		cout << ++x << "\t";
		while (true) {
			cout << y++ << "\t";
			break;
		}
		break;
	}*/


	/*while (true) {
		break;
		while (true) {

		}
	}*/



	// input: 5
	// output: 5 4 3 2 1 0

	// input: -5
	// output: -5 -4 -3 -2 -1 0

	/*
	* int num;
	cin >> num;
	while (true) {
		cout << num << endl;
		
		if (num == 0)
			break;

		num += (num > 0) ? -1 : 1;


		//if (num > 0) {
		//	cout << num-- << endl;

		//	if (num < 0)
		//		break;
		//}
		//else if(num < 0) {
		//	cout << num++ << endl;

		//	if (num > 0)
		//		break;
		//}
		//else {
		//	cout << num << endl;
		//	break;
		//}
	}
	*/

	/*char symbol = 'a';

	while (symbol <= 'z') {
		cout << symbol++ << endl;
	}*/




	char userInput;
	cout << "Enter 'B' for big alphabet: ", cin >> userInput;

	bool isBig = userInput == 'b' || userInput == 'B';

	int step = isBig ? 32 : 0;

	char symbol = 'a' - step;
	while (symbol <= 'z' - step) {
		cout << symbol++ << endl;
	}
}