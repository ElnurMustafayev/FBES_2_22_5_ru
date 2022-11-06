#pragma once

#include <iostream>

using namespace std;






// sum of types' sizes
template<typename T1, typename T2, typename T3>
int SumOfTypes(T1 param1, T2 param2, T3 param3) {
	int sizeofAllParams = sizeof(param1) + sizeof(param2) + sizeof(param3);
	return sizeofAllParams;
}

template<typename T1, typename T2, typename T3>
int SumOfTypes() {
	int sizeofAllTypes = sizeof(T1) + sizeof(T2) + sizeof(T3);
	return sizeofAllTypes;
}




template<typename T1, typename T2, typename TResult>
TResult MySum(T1 num1, T2 num2) {
	return (num1 + num2);
}

template<typename T1, typename T2>
void PrintSum(T1 num1, T2 num2) {
	cout << (num1 + num2) << endl;
}




// size >= 4 -> true
// else -> false
template<typename T>
void Task1() {
	return sizeof(T) >= 4;
}


template<typename TVar>
TVar Task2(int value) {
	TVar var = value;
	return var;
}




template<typename T>
int GetSize(T param) {
	return sizeof(T);
}



template<typename T>
int GetSize() {
	return sizeof(T);
}



template<typename T>
void Func(T start) {
	T temp = start % 5;	// will get error with T=double

	cout << sizeof(start) << endl;

	for (T i = start; i < 100; i++)
	{
		cout << sizeof(T) << ": " << i << endl;
	}

	cout << endl;
}










template<typename T>
void Print(T param) {
	cout << param << endl;
}




template<typename T>
T Sum(T num1, T num2) {
	return num1 + num2;
}

template<typename T>
T Minus(T num1, T num2) {
	return num1 - num2;
}

template<typename T>
T Mult(T num1, T num2) {
	return num1 * num2;
}

template<typename T>
T Div(T num1, T num2) {
	return num1 / num2;
}



template<typename T>
void PrintObjectSize(T param) {
	cout << sizeof(param) << endl;
}










//int globalNum = 100;


//float Sum(float num1, float num2) {
//	return num1 + num2;
//}
//
//float Minus(float num1, float num2) {
//	return num1 - num2;
//}
//
//float Mult(float num1, float num2) {
//	return num1 * num2;
//}
//
//float Div(float num1, float num2) {
//	return num1 / num2;
//}
//
//
//
//long long Sum(long long num1, long long num2) {
//	return num1 + num2;
//}
//
//long long Minus(long long num1, long long num2) {
//	return num1 - num2;
//}
//
//long long Mult(long long num1, long long num2) {
//	return num1 * num2;
//}
//
//long long Div(long long num1, long long num2) {
//	return num1 / num2;
//}