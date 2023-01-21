#include <iostream>

using namespace std;

class Car {
private:
    double speed;

public:
    void Method() {
        // 1 (edit another object)
        Car car = Car();
        car.speed = 123;

        // 2 (edit caller object)
        this->speed = 123;
    }
};

class Person {
public:
    string name;
    int age;

    void Method() {
        Person person = Person();
        person.name = "Bob";
        person.age = 15;
    }

    void InitializePerson(string name, int age) {
        this->name = name;
        this->age = age;
    }

    void SayHi() {
        cout << "Person: \"Hello!\"" << endl;
    }
};

struct Product {
private:
    double amount = 0;
    string name = "Unknown";

public:
    void Show(Product* This) {
        cout << "name: " << This->name << endl;
        cout << "amount: " << This->amount << "$" << endl;
    }

    void Init(string name, double amount) {
        this->name = name;
        this->amount = amount;
    }

    void Show() {
        cout << "name: " << this->name << endl;
        cout << "amount: " << this->amount << "$" << endl;
    }
};

int main()
{
    Product product;

    product.Init("test", 0.1);
    product.Init("one", 2);
    product.Show();








    /*
    Product product;

    product.Show();
    //Product::Show(&product);
    */







    /*Person person = Person();

    person.InitializePerson("Bob", 15);

    cout << "name: " << person.name << endl;
    cout << "age: " << person.age << endl;*/






    /*Person person = Person();
    person.Method();

    cout << "name: " << person.name << endl;
    cout << "age: " << person.age << endl;*/
}