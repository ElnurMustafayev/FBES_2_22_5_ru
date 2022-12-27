#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <conio.h>
#include <Windows.h>

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



//void ReadAllText(FILE* stream) {
//	
//
//	while (!feof(stream)) {
//		int symbol = fgetc(stream);
//
//		cout << (char)symbol;
//	}
//
//	cout << endl;
//}


long GetSize(FILE* stream) {
	long oldPositoin = ftell(stream);
	fseek(stream, 0, SEEK_END);
	int length = ftell(stream);
	fseek(stream, oldPositoin, SEEK_SET);

	return length;
}


void main()
{
	/*FILE* file = fopen("qwerty.txt", "w");

    int nums[]{
        123,645,345345,567567,99999
    };

    fwrite(nums, sizeof(int), 5, file);

    fclose(file);*/



    /*FILE* file = fopen("qwerty.txt", "r");

    int* nums = new int[4] {};

    fread(nums, sizeof(int), 4, file);

    for (int i = 0; i < 4; i++)
    {
        cout << nums[i] << endl;
    }
    fclose(file);*/





	//remove("assets\\nums.bin");

	FILE* file = fopen("assets\\nums.bin", "r");

	const int length = 5;

	/*
	// binary write
	int nums[length]{
		111,222,333,44,55
	};

	fwrite(nums, sizeof(nums[0]), length, file);*/
	
	/*
	// binary read
	int* destinationNums = new int[length] {};
	fread(destinationNums, sizeof(int), length, file);

	for (size_t i = 0; i < length; i++)
	{
		cout << destinationNums[i] << endl;
	}*/
	
	
	
	
	




	/*FILE* f = fopen("assets\\note.txt", "r+");

	int fileSize = GetSize(f);

	for (int i = 0; i < fileSize / 3; i++)
	{
		fseek(f, 2, SEEK_CUR);
		fputc('1', f);
	}*/




	/*FILE* f = fopen("lorem.txt", "r");
	fseek(f, -100, SEEK_END);
	fseek(f, 50, SEEK_CUR);

	while (!feof(f)) {
		cout << (char)fgetc(f);
	}*/

	/*fseek(f, 0, SEEK_END);
	int length = ftell(f);
	cout << length << endl;
	fseek(f, 0, SEEK_SET);

	int pos = 0;
	while (!feof(f)) {
		cout << (char)fgetc(f);
		pos += 2;
		fseek(f, pos, SEEK_SET);

		if (pos >= length)
			break;
	}*/






	//int length = 1000;

	//char* text = new char[length] {};

	//cout << "Input some text: ";// , cin >> text;

	//cin.getline(text, length);

	//FILE* file = nullptr;
	//const char* filename = "writing.log";

	//file = fopen(filename, "w");

	//for (int i = 0; i < strlen(text); i++)
	//{
	//	fputc(text[i], file);
	//}
	//fclose(file);







	/*cin >> text;

	while (true) {
		char word[50]{};

		cin >> word;

		cout << word << endl;
	}*/

	/*cin.getline(text, length);

	cout << text << endl;*/

	/*int num;
	cin >> num;
	cout << num << endl;

	cin.ignore();
	char symbol;
	cin >> symbol;
	cout << symbol << endl;*/








	/*FILE* file = nullptr;
	const char* filename = "writing.log";

	try {
		file = fopen(filename, "w");

		if (file == nullptr) {
			cout << "Error in file creating. Filename: " << filename << endl;
			exit(400);
		}

		cout << (char)fputc('A', file) << endl;
		cout << (char)fputc('B', file) << endl;
		cout << (char)fputc('C', file) << endl;

		fclose(file);
	}
	catch (int code) {
		if (file != nullptr) {
			fclose(file);
		}
	}*/


	/*char filename[30]{};
	char fileextension[30]{};

	cin >> filename;
	cin >> fileextension;

	char filefullname[60]{};
	
	strcat(filefullname, filename);
	strcat(filefullname, ".");
	strcat(filefullname, fileextension);

	fopen(filefullname, "w");*/





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


	
	/*FILE* f = fopen("system.txt", "r");

	if (f != nullptr) {
		cout << "File opened or created successfully!" << endl;
	}
	else {
		cout << "File couldn't open or create!" << endl;
	}

	_getch();*/



	/*FILE* f = fopen("lorem.txt", "r");

	while (!feof(f)) {
		Sleep(1);
		cout << (char)fgetc(f);
	}*/

	/*const int length = 1500;
	char buffer[length]{};

	FILE* f = fopen("lorem.txt", "r");

	for (int i = 0; feof(f) == false && i < length; i++)
	{
		buffer[i] = fgetc(f);
	}

	cout << "text: " << buffer << endl;*/

	/*while (!feof(f)) {
		Sleep(1);
		cout << (char)fgetc(f);
	}*/
}