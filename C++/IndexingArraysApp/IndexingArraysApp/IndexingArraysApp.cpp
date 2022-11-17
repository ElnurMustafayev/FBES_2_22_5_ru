//#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;

//void GetFirstWord(char text[], int length) {
//	for (int i = 0; i < length; i++)
//	{
//		if (text[i] == ' ') {
//			text[i] = '\0';
//			break;
//		}
//		text[i] = 'q';
//	}
//}


template<typename T>
void PrintArray(T arr[], int length) {
	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << endl;
	}
}

void PrintArray(char arr[]) {
	int i = 0;
	while (arr[i] != '\0') {
		cout << arr[i++] << endl;
	}
}

void Cut(char text[], int index) {
	if (index < 0) {
		cout << "Index can not be negative!" << endl;
		return;
	}

	// get length
	int length = 0;
	while (text[length] != '\0') {
		length++;
	}

	// validation
	if (index > length) {
		cout << "Index >= length!" << endl;
		return;
	}

	// cut
	text[index] = '\0';
}


int main()
{
	char text[26] = {
		'H','e','l','l','o',' ','w','o','r','l','d','!',' ','D','u','n','y','a',' ','s','a','l','a','m','!'
	};

	Cut(text, 27);
	Cut(text, 3);
	Cut(text, 5);

	cout << text << endl;

	// cut text to index
	// check index out of range

	/*Cut(text, -5);

	cout << text << endl;*/



	//// "Hello world!!! Dunya salam"

	//const int length = 25;

	//char text[length] = {
	//	'H','e','l','l','o',' ','w','o','r','l','d','!',' ','D','u','n','y','a',' ','s','a','l','a','m','!'
	//};
	//PrintArray(text);

	////GetFirstWord(text, length);

	//cout << text << endl;


	




	/*const int length = 10;

	char chars[length]{ 'a', 'b', 'c', 'd', 'q' };

	for (int i = 0; i < length; i++)
	{
		cout << chars[i] << endl;
	}*/

	//cout << chars << endl;


	/*int chars[3]{ 'a','b','c' };

	cout << chars << endl;
	cout << "[0] = " << &chars[0] << endl;
	cout << "[1] = " << &chars[1] << endl;
	cout << "[2] = " << &chars[2] << endl;*/
}