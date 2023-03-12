#include <iostream>
#include <string>
#include <fstream>
#include <vector>

using namespace std;

struct Person {
	string name;
	string surname;
	int age;

	vector<int> marks = vector<int>();

	/*void Save(ofstream& write) {
		write << "Name: " << this->name << endl;
		write << "Surname: " << this->surname << endl;
		write << "Age: " << this->age << endl;
	}*/
};

void WriteNumbersInFile(ofstream& write, int min = 1, int max = 100) {
	//ofstream write = ofstream(filename, std::ios_base::app);

	write << endl;
	for (int i = min; i <= max; i++)
	{
		write << i << "\t";
		if (i % 10 == 0)
			write << endl;
	}
}

// VECTOR
template<typename T>
ostream& operator<<(ostream& out, vector<T>& v) {
	for (auto item : v) {
		out << item << ' ';
	}

	return out;
}

template<typename T>
istream& operator>>(istream& in, vector<T>& v) {
	T temp;
	while (!in.eof()) {
		in >> temp;
		v.push_back(temp);
	}

	return in;
}

// PERSON
ostream& operator<<(ostream& out, Person& p) {
	out << /*"Name: " <<*/ p.name << endl;
	out << /*"Surname: " <<*/ p.surname << endl;
	out << /*"Age: " <<*/ p.age << endl;

	out << p.marks << endl;

	return out;
}

istream& operator>>(istream& in, Person& p) {
	in >> p.name;
	in >> p.surname;
	in >> p.age;
	in >> p.marks;

	return in;
}



int main()
{
	// OOP
	if (false) {
		Person p = Person();
		//p.marks.push_back(10);
		//p.marks.push_back(11);
		//p.marks.push_back(12);
		//
		//p.name = "Vova";
		//p.surname = "Ivanov";
		//p.age = 15;

		//ofstream write = ofstream("Vova.txt", std::ios_base::trunc);
		//write << p;

		ifstream read = ifstream("Vova.txt");
		read >> p;

		cout << p << endl;
	}

	if (false) {
		//Person p = Person();
		//p.name = "Jane";
		//p.surname = "Brown";
		//p.age = 27;
		//
		//ofstream write = ofstream("admin.txt", std::ios_base::trunc);
		//write << p;

		Person admin = Person();
		
		/*cin >> admin;
		cout << admin;*/

		ifstream read = ifstream("admin.txt");
		//read.close();
		read >> admin;
		//cout << admin << endl;

		admin.age++;
		
		ofstream write = ofstream("admin.txt", std::ios_base::trunc);
		write << admin;

		



		//p.Save(write);

		//ofstream write = ofstream("admin.txt", std::ios_base::trunc);
		//write << "Name: " << p.name << endl;
		//write << "Surname: " << p.surname << endl;
		//write << "Age: " << p.age << endl;
	}

	// File Read
	if (false) {
		ifstream read = ifstream("test.txt");
		//int num = 0;
		//read >> num;
		//read >> num;
		//
		//cout << num << endl;

		/*string str;
		while (getline(read, str)) {
			cout << str << endl;
		}*/

		//getline(read, str);
		//read >> str;

		//cout << str << endl;

		//int d;
		//read >> d;
		//cout << d << endl;
	}

	// File Write
	if (false) {
		//ofstream write = ofstream("data.txt", std::ios_base::app);
		//write << 111 << endl;
		//write << 222 << endl;
		//write << 333 << endl;

		//write << 'a' << endl;
		//write << (char)97 << endl;

		//write << "Hello World\n";

		/*write << "Number: " << endl;
		write << "\tone" << endl;
		write << "\ttwo" << endl;
		write << "\tthree" << endl;*/

		//char msg[] = "Char Array";
		//write << msg << endl;

		//std::setlocale(LC_ALL, "de_DE");
		//double d = 10.512;
		//write << d << endl;

		//write << true << endl;

		// alphabet
		//for (char i ='a'; i <= 'z'; i++)
		//{
		//	write << i << ' ';
		//}


		// function: WriteNumbersInFile
		//	1	2	3	...	10
		//	11	12	13	...	20
		//	...	...	...	...	...
		//	91	92	93	...	100

		//WriteNumbersInFile("numbers.txt", 1, 30);
		//ofstream write = ofstream("numbers.txt", std::ios_base::app);
		//WriteNumbersInFile(write);
	}
}