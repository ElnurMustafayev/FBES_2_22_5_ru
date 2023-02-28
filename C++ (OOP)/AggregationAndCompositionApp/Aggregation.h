#pragma once

struct Engine {
	double Power;
	int Hp;
};

class Car {
public:
	Person* driver;
	string name;
	Engine* engine = nullptr;

	Car(string name) : name(name) {}

	~Car()
	{

	}
};



enum GENDER {
	Male, Female, Other
};

struct Person {
	string FIN;
	string name;
	GENDER gender;
	Person* partner = nullptr;

	Person() {}
	Person(string FIN, string name, GENDER gender)
		: FIN(FIN),
		name(name),
		gender(gender) {}
};

struct PeopleStorage {
	map<string, Person> people = map<string, Person>();
};