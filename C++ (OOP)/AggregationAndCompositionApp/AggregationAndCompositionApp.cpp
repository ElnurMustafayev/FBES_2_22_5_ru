#include <iostream>
#include <vector>
#include <map>
using namespace std;

#include "Composition.h"
#include "Aggregation.h"

int main()
{
	{
		Book myBook = Book();
		myBook.name = "My Book";
		myBook.pages.push_back(Page(1, 300));
		myBook.pages.push_back(Page(2, 400));
		myBook.pages.push_back(Page(3, 400));
		myBook.pages.push_back(Page(4, 400));
		myBook.pages.push_back(Page(5, 300));

		myBook.Show();
	}

	{
		Engine superEngine = Engine();
		superEngine.Power = 6;
		superEngine.Hp = 800;

		Car car1 = Car("BMW M3");
		car1.engine = &superEngine;

		/*Car car2 = Car("Porcshe Turbo S");
		car2.engine = car1.engine;
		car1.engine = nullptr;*/
	
		PeopleStorage storage = PeopleStorage();
		storage.people["YWUE23A"] = Person("YWUE23A", "Bob", GENDER::Male);
		storage.people["ABC3456"] = Person("ABC3456", "Ann", GENDER::Female);
		storage.people["TYS67SD"] = Person("TYS67SD", "Kate", GENDER::Female);
		storage.people["TWYQW42"] = Person("TWYQW42", "John", GENDER::Male);
		storage.people["35SAD23"] = Person("35SAD23", "Jane", GENDER::Female);

		storage.people["YWUE23A"].partner = &storage.people["TYS67SD"];
		storage.people["TYS67SD"].partner = &storage.people["YWUE23A"];

		car1.driver = &storage.people["YWUE23A"];
		car1.driver = nullptr;

		car1.driver = &storage.people["TWYQW42"];
	}
}