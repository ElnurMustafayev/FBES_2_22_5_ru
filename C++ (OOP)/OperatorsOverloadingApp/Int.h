#pragma once

struct Int {
private:
	int value;

public:
	Int(int value)
	{
		this->value = value;
	}

	int GetValue() {
		return value;
	}



	bool operator == (Int num) {
		return this->value == num.value;
	}

	bool operator != (Int num) {
		//return !(*this == num);
		//return *this != num;				inf recursion
		return this->value != num.value;
	}

	Int operator += (int num) {
		this->value += num;
		return *this;
	}

	Int operator += (Int num) {
		this->value += num.value;
		return *this;
	}
	
	Int operator + (int num) {
		Int result = Int(this->value + num);
		return result;
	}

	Int operator + (Int num) {
		cout << "SUM" << endl;
		return Int(this->value + num.value);
	}

	Int operator ++ () {
		this->value++;
		return *this;
	}

	Int operator ++ (int) {
		this->value++;
		return *this;
	}

	Int operator -- () {
		cout << "PRE" << endl;
		this->value--;
		return *this;
	}

	Int operator -- (int) {
		cout << "POST" << endl;
		this->value--;
		return *this;
	}

	Int operator -= (int num) {
		this->value -= num;
		return *this;
	}

	Int operator - (int num) {
		Int result = Int(this->value - num);
		return result;
	}
};