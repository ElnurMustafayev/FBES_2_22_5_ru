#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;




/*

	// there are error code
	// please write in throw
	const int notFoundErrorCode = 404;
	const int argumentErrorCode = 400;

*/



const int namesCount = 6;
char names[namesCount][20] = {
		"Emil",
		"Emin",
		"Sadiq",
		"Aydin",
		"Ramil",
		"Tarana",
};

int ages[namesCount] = { 20, 30, 16, 28, 24, 25 };

enum ERROR_CODES : int {
	not_found = 404,
	argument_null = 400,
};

int GetUserAge(char* name) {
	// invalid argument
	if (name == nullptr)
		throw (int)ERROR_CODES::argument_null;

	name = _strupr(name);
	int length = strlen(name);

	for (int x = 0; x < namesCount; x++)
	{
		char* currentName = names[x];
		int currentLength = strlen(currentName);

		// name.length != names[x].length
		if (length != currentLength) {
			continue;
		}

		// normalize
		currentName = _strupr(currentName);

		//name[i] == currentName[i]
		bool areEqual = true;
		for (int i = 0; i < currentLength; i++)
		{
			if (name[i] != currentName[i]) {
				areEqual = false;
				break;
			}
		}

		// success
		if (areEqual == true)
			return ages[x];
	}

	// not found
	throw (int)ERROR_CODES::not_found;
}


enum GENDERS {
	male, female, other, unknown
};


void PrintGender(GENDERS gender) {
	cout << "Gender: ";

	switch (gender)
	{
	case GENDERS::male:
		cout << "male";
		break;
	case GENDERS::female:
		cout << "female";
		break;
	case GENDERS::other:
		cout << "other";
		break;
	default:
	case GENDERS::unknown:
		cout << "unknown";
		break;
	}

	cout << endl;
}


int main()
{
	char name[20] = "Bob";
	GENDERS gender = GENDERS::male;

	cout << "Name: " << name << endl;
	PrintGender(gender);

	/*cout << sizeof(ERROR_CODES) << endl;
	cout << sizeof(ERROR_CODES::argument_null) << endl;*/

	//ERROR_CODES code = ERROR_CODES::argument_null;
	/*ERROR_CODES code = (ERROR_CODES)151;

	cout << code << endl;

	switch (code)
	{
	case ERROR_CODES::not_found:
		break;
	case ERROR_CODES::argument_null:
		break;
	default:
		break;
	}*/

	/*try {
		throw ERROR_CODES::argument_null;
	}
	catch (ERROR_CODES code) {
		cout << code << endl;
	}
	catch (int code)
	{
		cout << code << endl;
	}*/



	/*try {
		char name[] = "qwerty";
		cout << GetUserAge(name) << endl;
		cout << GetUserAge(nullptr) << endl;
	}
	catch (int code) {
		if (code == ERROR_CODES::argument_null) {
			cout << code << ": Argument Exception..." << endl;
		}

		if (code == ERROR_CODES::not_found) {
			cout << code << ": Not Found Exception..." << endl;
		}
	}*/
}