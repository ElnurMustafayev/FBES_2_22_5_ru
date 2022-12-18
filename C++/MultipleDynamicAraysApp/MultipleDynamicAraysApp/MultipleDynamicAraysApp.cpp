#include <iostream>

using namespace std;

int main()
{
	int* ptr1 = new int[3];
	int* ptr2 = new int[3];
	int* ptr3 = new int[3];


	int** arr = new int* [3] {
		ptr1,
		ptr2,
		ptr3,
	};

	//int* arr[3]{};






	// single
	/*int* arr = new int[10] {
		123,123,12,412,41,24
	};*/


	
	// multiple

	/*int** arr = new int*[3] {
		new int[3] {},
		new int[3] {},
		new int[3] {},
	};*/

	/*cout << arr[0] << endl;
	cout << arr[1] << endl;
	cout << arr[2] << endl;*/

	//int num = 123;
	//cout << arr << endl;	// heap address
	//cout << &arr << endl;	// stack address
}