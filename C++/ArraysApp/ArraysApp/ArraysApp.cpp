#include <iostream>

using namespace std;

void PrintArray(int arr[], int length);
void PrintHalfOfArray(int arr[], int length);

int main() {
	/*int arr[3] { 
		1, 2
	};*/

	/*arr[0] = 123123;
	arr[1] = 4534;
	arr[2] = 586586;*/

	//cout << arr[0] << endl;

	//cout << arr << endl;



	/*int arr[40]{1,6,8,4,7,5};


	cout << arr[5] << endl;
	cout << arr[10] << endl;*/




	/*int arr[7]{
		true,
		123.3453,
		'a',
		123 + 234,
		Test()
	};

	cout << arr[0] << endl;
	cout << arr[1] << endl;
	cout << arr[2] << endl;
	cout << arr[3] << endl;
	cout << arr[4] << endl;
	cout << arr[5] << endl;
	cout << arr[6] << endl;*/



	/*double balances[5]{
		12345.4,
		123.65,
		0,
		23.50,
		100,
	};

	cout << sizeof(balances) << endl;*/



	/*char word[10]{
		'H', 'e', 'l', 'l', 'o'
	};

	cout << word << endl;*/



	/*const int length = 15;

	int arr[length]{
		1,2,3
	};

	PrintHalfOfArray(arr, length);*/


	//int test2 = 30;

	//const int length = 10 + test2;

	//int arr[length]; // error
}




void PrintHalfOfArray(int arr[], int length) {
	for (int i = 0; i < length / 2; i++)
		cout << i << ". " << arr[i] << endl;
}

void PrintArray(int arr[], const int length) {
	for (int i = 0; i < length; i++)
	{
		cout << i << ". " << arr[i] << endl;
	}
}