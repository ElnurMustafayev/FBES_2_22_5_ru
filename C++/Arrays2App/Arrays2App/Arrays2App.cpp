#include <iostream>

using namespace std;

//void Test(int arr[]) {
//	cout << arr[2] << endl;
//}

//void Test(int* arr) {
//	cout << arr[3] << endl;
//}


void Print(int* arr, const int length) {
	for (size_t i = 0; i < length; i++)
	{
		cout << *(arr + i) << endl;
	}
}

template<typename T>
void PrintReverse(T* arr, int length) {
	for (int i = length - 1; i >= 0; i--)
	{
		//cout << arr[i] << endl;
		cout << *(arr + i) << endl;
	}

	/*
	while (length)
	{
		cout << arr[i] << endl;
		cout << *(arr + i) << endl;
		cout << *(arr + --length) << endl;
	}
	*/
}



int* ClearArray(int arr[], const int length) {
	for (int i = 0; i < length; i++)
		arr[i] = 0;

	return arr;
}


// numeric
//template<typename T>
//T* InitArrayOf10() {
//	T arr[10]{};
//	int length = sizeof(arr) / sizeof(T);
//
//	for (int i = 0; i < length; i++)
//	{
//		arr[i] = i + 1;
//	}
//
//	return arr;
//}





int main()
{
	//InitArrayOf10<int>();


	/*int arr[]{ 1,2,3 };

	int* resultArr = ClearArray(arr, 3);

	PrintReverse(resultArr, 3);*/




	//const int length = 5;

	//int arrI[length]{
	//	2,2,9,4,6
	//};

	//double arrD[length]{
	//	1.312, 4.353, 57.235, 789.35, 0.3
	//};

	////Print(arr, length);
	//PrintReverse(arrI, length);

	//int* ptr = arr;

	// 1,2,3,4,5
	// *(ptr + 2)

	/*cout << ptr[2] << endl;
	cout << *(ptr + 2) << endl;*/

	//cout << ptr[2] << endl;




	//Test(arr);

	//int* ptr = arr;

	/*cout << ptr << endl;
	cout << arr << endl;*/
}