#include <iostream>

using namespace std;

/*

struct Person {
    char name[30]{};
    char surname[30]{};

    int age = -1;
};



Person CreatePerson(const int age, const char* surname, const char* name) {
    if (name == nullptr || surname == nullptr) {
        throw "Name or surname can not be empty!";
    }
    else if (age < 0) {
        throw "Age can not be less than 0!";
    }

    // init
    Person person = Person();

    // set
    strcpy_s(person.name, name);
    strcpy_s(person.surname, surname);
    person.age = age;

    return person;
}

void ShowPerson(Person person) {
    cout << person.name << " " << person.surname << endl;
    cout << person.age << " years old" << "\n\n";
}

char* InputName() {
    char* name = new char[30]{};
    cout << "Name: ";
    cin >> name;
    return name;
}

char* InputSurname() {
    char* surname = new char[30]{};
    cout << "Surname: ";
    cin >> surname;
    return surname;
}

int InputNumber(const char* message) {
    int num;
    cout << message << ": ";
    cin >> num;
    return num;
}

void mainOne()
{
    try {
        Person person1 = CreatePerson(InputNumber("Age"), InputSurname(), InputName());
        ShowPerson(person1);

        Person person2 = CreatePerson(InputNumber("Age"), InputSurname(), InputName());
        ShowPerson(person2);
    
        Person person3 = CreatePerson(InputNumber("Age"), InputSurname(), InputName());
        ShowPerson(person3);
    }
    catch (const char* message) {
        cout << "Error: " << message << endl;
    }
}
*/