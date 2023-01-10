//#include <iostream>
//
//using namespace std;
//
//
//enum CAR_MODELS {
//    offroad,
//    sedan,
//    universal,
//    hatchback
//};
//
//enum GEARBOX_TYPES {
//    manual,
//    automatic
//};
//
//enum COLORS {
//    black,
//    silver,
//    gray,
//    white,
//    maroon,
//    red,
//    purple,
//    fuchsia,
//    green,
//    lime,
//    olive,
//    yellow,
//    navy,
//    blue,
//    teal,
//    aqua,
//};
//
//struct Car {
//    char name[50]{};
//    double speed;
//    int seatsCount = 4;
//    CAR_MODELS model = CAR_MODELS::sedan;
//    GEARBOX_TYPES gearbox = GEARBOX_TYPES::automatic;
//    COLORS color = COLORS::white;
//};
//
//enum Genders {
//    male, female
//};
//
//struct Person {
//    char name[30]{};
//    Genders gender;
//    bool isMarried = false;
//    Person* partner = nullptr;
//};
//
//void Wedding(Person& p1, Person& p2) {
//    p1.isMarried = true;
//    p2.isMarried = true;
//    p1.partner = &p2;
//    p2.partner = &p1;
//}

//void ChangeNum(int& num) {
//    num++;
//}

//int mainTwo()
//{
    //int num = 100;
    //ChangeNum(num);
    //cout << num << endl;
    //
    //Person woman = Person();
    //strcpy_s(woman.name, "Ann");
    //woman.gender = Genders::female;
    //
    //Person man = Person();
    //strcpy_s(man.name, "Bob");
    //man.gender = Genders::male;
    //
    //Wedding(man, woman);


    //man.name;
    //man.partner->name;
    //
    //Person p = Person();
    //p.name;
    //
    //Person* ptr = &p;
    //ptr->name;
    //
    //cout << (man.partner->partner->partner->name) << endl;




    //Car car = Car();
    //strcpy_s(car.name, "BMW 530");
    //cout << car.name << endl;
    //
    //Car* carPtr = &car;
    //carPtr->speed = 123;*/
    //
    ///*Car car1 = Car();
    //Car* car2 = new Car();
    //
    //cout << &car1 << endl;
    //cout << car2 << endl;
    //
    //
    //Car** garage1 = new Car*[5]{
    //    new Car(),
    //    new Car(),
    //    new Car(),
    //    new Car(),
    //    new Car(),
    //};
    //
    //Car* garage2 = new Car[5] {
    //    Car(),
    //    Car(),
    //    Car(),
    //    Car(),
    //    Car(),
    //};
    //
    //garage1[0]->model = CAR_MODELS::universal;
    //garage2[0].model = CAR_MODELS::universal;
    //}
//