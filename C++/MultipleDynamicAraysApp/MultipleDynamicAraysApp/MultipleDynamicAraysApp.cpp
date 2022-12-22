#include <iostream>

using namespace std;


template<typename T>
T* AddElement(T* arr, int& length, T value, int index) {
    if (index < 0 || index > length)
        throw "incorrect index in AddElement";

    T* newArr = new T[length + 1]{};

    // copy
    for (int i = 0; i < index; i++)
        newArr[i] = arr[i];

    newArr[index] = value;

    for (int i = index; i < length; i++)
        newArr[i + 1] = arr[i];

    delete[] arr;

    length++;

    return newArr;
}



template<typename T>
T* DeleteElement(T* arr, int& length, const int index) {
    if (arr == nullptr)
        throw "Array can not be empty in DeleteElement";

    if (index < 0 || index >= length)
        throw "incorrect index in DeleteElement";

    T* newArr = new T[length - 1]{};

    for (int i = 0; i < index; i++)
        newArr[i] = arr[i];

    for (int i = index; i < length - 1; i++)
        newArr[i] = arr[i + 1];

    length--;

    delete[] arr;

    return newArr;
}


int* AddElement(int* arr, int newElement, int& length) {
	// 1. init
	int* newArr = new int[length + 1];

	// 2. copy
	for (int i = 0; i < length; i++)
		newArr[i] = arr[i];

	// 3. add new element
	newArr[length++] = newElement;

	// 4. delete old arr
	delete[] arr;

	// 5. return new arr
	return newArr;
}

void PrintArr(const int* arr, const int length) {
	cout << "Length: " << length << endl;

	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << " ";
	}
	cout << "\n\n";
}


int main()
{
	// int length = 3;
    // int* arr = new int[length] {8, 3, 5};

    // try {
    //     cout << "1: " << endl;
    //     Print(arr, length);


    //     arr = AddElement(arr, length, 7, 2);
    //     cout << "2: " << endl;
    //     Print(arr, length);


    //     DeleteElement(arr, length, 1);
    //     cout << "3: " << endl;
    //     Print(arr, length);
    // }
    // catch (const char* errorMessage) {
    //     cout << "Error: " << errorMessage << endl;
    // }




	/*int length = 5;
	int** arr = new int*[length] {};
	for (int i = 0; i < length; i++)
		delete[] arr[i];

	delete[] arr;*/

	/*int length = 5;

	int arr0l = 0;
	int arr1l = 0;
	int arr2l = 0;

	int* arrLengthes = new int[length] {
		1, 3, 4, 5
	};

	int** arr = new int* [length];
	for (int i = 0; i < length; i++)
		arr[i] = new int[arrLengthes[i]] {};

	arr[0] = AddElement(arr[0], 2, arrLengthes[0]);
	arr[0] = AddElement(arr[0], 8, arrLengthes[0]);
	arr[0] = AddElement(arr[0], 7, arrLengthes[0]);

	for (int i = 0; i < length; i++)
	{
		PrintArr(arr[i], arrLengthes[i]);
	}*/





	/*int num = 100;
	int arr[3]{};


	int** dynamicArr = new int* [10] {
		&num,
		new int(123),
		arr,
		new int[1] {},
		new int[2] {},
		new int[3] {},
	};*/










	/*int arr[3][3]{
		{1,2,3},
		{4,5,6},
		{7,8,9},
	};

	cout << &arr << endl;
	cout << arr << endl;
	cout << arr[0] << endl;
	cout << &arr[0][0] << endl;*/


	//int* ptr1 = new int[3]{};
	//int* ptr2 = new int[3]{};
	//int* ptr3 = new int[3]{};

	//int** arr = new int* [3] {
	//	ptr1,
	//	ptr2,
	//	ptr3,
	//};

	//cout << &arr << endl;			// address of arr
	//
	//cout << arr << endl;			// address to first element
	//cout << *arr << endl;			// value of first element
	//cout << (&arr[0][0]) << endl;
	//cout << (arr[0]) << endl;





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