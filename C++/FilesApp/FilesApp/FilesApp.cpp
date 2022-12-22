#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;


//char* gen_random(const int len) {
//	static const char alphanum[] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
//	char* result = new char[len + 1] {};
//
//	for (int i = 0; i < len; ++i) {
//		result[i] = alphanum[rand() % 63];
//	}
//
//	return result;
//}



void ReadAllText(FILE* stream) {
	

	while (!feof(stream)) {
		int symbol = fgetc(stream);

		cout << (char)symbol;
	}

	cout << endl;
}



void main()
{
	char filename[30]{};
	char fileextension[30]{};

	cin >> filename;
	cin >> fileextension;

	char filefullname[60]{};
	
	strcat(filefullname, filename);
	strcat(filefullname, ".");
	strcat(filefullname, fileextension);

	fopen(filefullname, "w");





	/*srand(time(0));
	for (int i = 0; i < 10000; i++)
	{
		char filepath[1000] {};

		strcat(filepath, "C:\\Users\\mustafayev_e\\Desktop\\test\\");
		strcat(filepath, gen_random(15));
		strcat(filepath, ".txt");

		FILE* file = fopen(filepath, "w");
	}*/

	/*const char* filename = "C:\\Users\\mustafayev_e\\Desktop\\test\\testqwerty.txt";

	FILE* file = fopen(filename, "w");
	if (file == nullptr) {
		cout << "Couldn't open filestream for " << filename << endl;
		return;
	}*/

	//cout << "Stream address: "  << file << endl;
	//ReadAllText(file);




	/*int result = fgetc(file);

	cout << result << endl;*/

	/*do {
		int symbol = fgetc(file);

		if (symbol == EOF)
			break;

		cout << (char)symbol << endl;
	} while (true);*/


	

}