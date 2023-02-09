#pragma once

#include <iostream>

using namespace std;

struct String {
	string value;

	String(string value) : value(value) {}
	String(const char* value) : value(value) {}

	String operator + (const char* value) {
		return String(this->value + value);
	}

	String operator + (String str) {
		return String(this->value + str.value);
	}

	String operator += (const char* value) {
		this->value += value;
		return *this;
	}

	String operator += (String str) {
		this->value += str.value;
		return *this;
	}

	String operator *= (int num) {
		string result;

		for (int i = 0; i < num; i++)
			result += this->value;

		this->value = result;

		return *this;
	}
};