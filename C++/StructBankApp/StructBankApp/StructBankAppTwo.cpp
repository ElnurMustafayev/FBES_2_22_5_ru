#include <iostream>

using namespace std;

enum Genders {
    male, female
};

struct Person {
    char name[30]{};
    Genders gender;
    bool isMarried = false;
    Person* partner = nullptr;
};

void Wedding(Person& p1, Person& p2) {
    p1.isMarried = true;
    p2.isMarried = true;
    p1.partner = &p2;
    p2.partner = &p1;
}

//void ChangeNum(int& num) {
//    num++;
//}

int main()
{
    /*int num = 100;
    ChangeNum(num);
    cout << num << endl;*/

    Person woman = Person();
    strcpy_s(woman.name, "Ann");
    woman.gender = Genders::female;

    Person man = Person();
    strcpy_s(man.name, "Bob");
    man.gender = Genders::male;
    
    Wedding(man, woman);


    /*
    man.name;
    man.partner->name;
    
    Person p = Person();
    p.name;

    Person* ptr = &p;
    ptr->name;
    
    cout << (man.partner->partner->partner->name) << endl;
    */
}