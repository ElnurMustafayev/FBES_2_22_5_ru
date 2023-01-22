#include <iostream>

using namespace std;

enum STATUS {
    active = 1,
    blocked,
    deleted
};

string GetStatusStr(int value) {
    switch (value)
    {
    case active:
        return "active";
    case blocked:
        return "blocked";
    case deleted:
        return "deleted";
    default:
        return "unknown";
    }
}

class Contact {
    int age = 0;
    STATUS status = STATUS::active;
    int showCounter = 0;
public:
    string name;
    string phoneNumber;
    string mail;

    // accessor for field 'age'
    // getter
    int GetAge() {
        return this->age;
    }

    // setter
    void SetAge(int age) {
        if (age >= 0 && age <= 130) {
            this->age = age;
        }
        else
        {
            throw "Incorrect Age!";
        }
    }

    // accessor for field 'status'
    // getter
    STATUS GetStatus() {
        return this->status;
    }

    // setter
    void SetStatus(STATUS status) {
        if (STATUS::active <= status && status <= STATUS::deleted) {
            this->status = status;
        }
    }

    void Show() {
        showCounter++;
        cout << "Name: " << this->name << endl;
        cout << "Mail: " << this->mail << endl;
        cout << "Age: " << this->age << endl;
        cout << "Phone: " << this->phoneNumber << endl;
        cout << "Status: " << GetStatusStr(this->status) << "\n\n";
    }
};



struct Person {
private:
    string name = "unknown";
    int age;

public:
    // getter & setter: 'name'
    string GetName() {
        return this->name;
    }
    void SetName(string name) {
        if (name.length() == 0) {
            throw "name can not be empty!";
        }

        for (int i = 0; i < name.length(); i++)
        {
            char currentSymbol = toupper(name[i]);

            if (currentSymbol < 65 || currentSymbol > 90) {
                throw "name contains incorrect symbols!";
            }
        }

        this->name = name;
    }
};



int main()
{
    try {
        Person person = Person();
        person.SetName("Elnur");
        cout << person.GetName() << endl;
    }
    catch (const char* message) {
        cout << "Error: " << message << endl;
    }


    /*Contact contacts[50];

    for (int i = 0; i < 50; i++)
    {
        string number = contacts[i].phoneNumber;
        string countryCode = number.substr(0, 4);

        if (countryCode == "+994")
            cout << "Salam" << endl;
    }*/

    /*string str = "+994 (70) 300-88-20";
    string result = str.substr(0, 4);

    cout << (result == "+994") << endl;
    cout << result << endl;*/

    /*string str = "Qwerty";
    int length = str.length();*/



    /*try {
        Contact contact1 = Contact();
        contact1.name = "Elman";
        contact1.phoneNumber = "+994 (70) 300-88-20";
        contact1.mail = "elman@gmail.com";
        contact1.SetStatus(STATUS::active);
        contact1.SetAge(16);

        contact1.Show();


        Contact contact2 = Contact();
        contact2.name = "Eldaniz";
        contact2.mail = "eldaniz@gmail.com";
        contact2.phoneNumber = "+994 (51) 630 85-85";
        contact2.SetStatus((STATUS)15);
        contact2.SetAge(18);

        contact2.Show();
    }
    catch (const char* message) {
        cout << "Error: " << message << endl;
    }*/
}