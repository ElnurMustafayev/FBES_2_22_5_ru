#include <iostream>

using namespace std;


//int* GetArray(int length) {
//    return new int[length] {};
//}

//int* ptr;
//
//void Func() {
//	int arr[]{
//		1,2,3,4,5,6,7,8,9
//	};
//
//	ptr = arr;
//}


//int* Func() {
//	int* arr = new int[10] {
//		1, 2, 3, 4, 5, 6, 7, 8, 9
//	};
//
//	return arr;
//}



int* PushBack(int* arr, int* length, int newElement) {
	// create new array with length + 1
	int* newArr = new int[(*length) + 1] {};

	// copy all to new array
	for (int i = 0; i < *length; i++)
	{
		newArr[i] = arr[i];
	}

	// add new element to end
	newArr[*length] = newElement;

	(*length)++;

	return newArr;
}



int* PushFront(int* arr, int& length, int newElement) {
	int* newArr = new int[length + 1] {};

	newArr[0] = newElement;

	for (int i = 0; i < length; i++)
	{
		newArr[i + 1] = arr[i];
	}

	length++;

	return newArr;
}




int main()
{
	/*int* ptr = new int(123);
	int& num1 = *ptr;

	num1++;

	cout << num1 << endl;
	cout << *ptr << endl;*/



	/*
	int num = 100;

	// pointer
	
	int* numPtr = &num;
	cout << ++(*numPtr) << endl;
	cout << num << endl;
	

	// alias
	int& numAlias = num;
	cout << ++numAlias << endl;
	cout << &numAlias << endl;
	cout << num << endl;
	*/









	/*int length = 5;

	int* arr = new int[length] {
		1, 2, 3, 4, 5,
	};

	arr = PushBack(arr, &length, 777);
	arr = PushFront(arr, length, 111);
	arr = PushFront(arr, length, 222);
	arr = PushFront(arr, length, 333);

	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << endl;
	}*/





    /*int* arr = GetArray(10);

	for (int i = 0; i < 10; i++)
	{
		cout << arr[i] << endl;
	}*/



	/*Func();

	cout << *ptr << endl;
	cout << ptr[3] << endl;*/

	

	/*int num = Func()[3];

	cout << num << endl;*/
}