#include <iostream>

using namespace std;

//template<typename TPtr, typename TResult>
//TResult Convert(TPtr* ptr) {
//	TResult* resultPtr = (TResult*)ptr;
//	return *resultPtr;
//}

template<typename T1, typename T2>
int DifferenceOfAddresses(T1* ptr1, T2* ptr2) {
	return abs((bool*)ptr1 - (bool*)ptr2);
}

int main()
{
	int num1 = 123;
	short num2 = 546;

	int* numPtr1 = &num1;
	short* numPtr2 = &num2;

	cout << DifferenceOfAddresses(numPtr1, numPtr2) << endl;


	/*int num = 123;
	float result = Convert<int, float>(&num);
	cout << result << endl;*/

	/*int num1 = 100;
	double num2 = 12.45;

	int* ptr1 = &num1;
	double* ptr2 = &num2;

	cout << "Int*: " << ptr1 << " - " << sizeof(ptr1) << endl;
	cout << "Double*: " << ptr2 << " - " << sizeof(ptr2) << endl;
	cout << sizeof(bool*) << endl;
	cout << sizeof(short*) << endl;*/


	/*int num1 = 100;

	int* ptr1 = &num1;

	cout << *ptr1 << endl;*/



	/*int num = 777777;
	int* numPtr = &num;

	short* ptr1 = (short*)&num;
	short* ptr2 = (short*)numPtr;

	cout << *ptr1 << endl;*/



	/*short num = 11000;

	int* ptr = (int*)&num;

	cout << *ptr << endl;*/



	/*char num = 'a';
	bool* ptr = (bool*)&num;

	cout << *ptr << endl;*/






	// 123456
	// [1233] [345] [567] [0]

	/*int num = 123336;

	bool* stepPtr = (bool*)&num;
	bool first = *stepPtr;
	bool second = *(++stepPtr);
	bool third = *(++stepPtr);
	bool fourth = *(++stepPtr);

	cout << first << endl;
	cout << second << endl;
	cout << third << endl;
	cout << fourth << endl;*/



	/*int num1 = 132, num2 = 8678;
	int *ptr1 = &num1, *ptr2 = &num2;

	cout << ptr1 << endl;
	cout << ptr2 << endl;

	cout << (ptr1 - ptr2) << endl;*/
}