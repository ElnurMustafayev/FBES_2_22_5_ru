#pragma once

#include <iostream>

using namespace std;




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