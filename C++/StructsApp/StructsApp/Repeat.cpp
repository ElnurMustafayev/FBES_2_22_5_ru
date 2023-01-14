#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;


struct Test {
	int num;
	char symbol;
};

enum STATUS : int {
	error,
	warning,
	success
};

struct Exception {
	STATUS status = STATUS::error;
	char message[50];
	int code;
};


void FuncWithError() {
	Exception ex = Exception();
	ex.status = STATUS::warning;
	ex.code = 404;
	strcpy(ex.message, "not found!");
	throw ex;
}


const char* GetStatus(STATUS status) {
	switch (status)
	{
		case error:
			return "error";
		case warning:
			return "warning";
		case success:
			return "success";
		default:
			return "unknown";
	}
}

void ShowException(Exception ex) {
	cout << "message: " << ex.message << endl;
	cout << "code: " << ex.code << endl;
	cout << "status: " << GetStatus(ex.status) << endl;
}


void main() {
	try {
		FuncWithError();
	}
	catch (Exception ex) {
		ShowException(ex);
	}

	/*
		try {
			// Test t = Test();
			// t.num = 123;
			// t.symbol = '#';
			// throw t;

			Test t = Test();
			if (false) {
				t.num = 123;
				t.symbol = '#';
				throw t;
				throw new int(123);
			}
			else {
				t.num = 404;
				t.symbol = '*';
				throw t;
				throw new char('@');
			}
		}
		catch (Test t) {
			if (t.num == 123) {
				cout << "ONE" << endl;
			}
			else if (t.num == 404) {
				cout << "TWO" << endl;
			}
			else if (t.num == 404 && t.symbol == '*') {
				cout << "THREE" << endl;
			}
			else {
				cout << "FOUR" << endl;
			}

			cout << "NUM: " << t.num << endl;
			cout << "SYMBOL: " << t.symbol << "\n\n";
			cout << "TEST STRUCT" << endl;
		}
		catch (int num) {
			cout << "INT: " << num << endl;
		}
		catch (char symbol) {
			cout << "CHAR: " << symbol << endl;
		}
	*/
}