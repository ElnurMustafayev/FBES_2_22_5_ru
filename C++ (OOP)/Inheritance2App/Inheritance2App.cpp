#include <iostream>
#include <map>

using namespace std;

template<typename T>
void PrintBytes(T* obj) {
    bool* stepper = (bool*)obj;

    for (int i = 0; i < sizeof(T); i++)
    {
        if (i % 8 == 0 && i != 0)
            cout << endl;

        cout << *(stepper) << endl;
        stepper++;
    }
}

class Temp {
private:
    //int var1 = 111;         // 4        -- 8
    //char* var2 = nullptr;   // 8        -- 8
    //bool var3 = false;      // 1        -- 8

    void Func1() {}
    int Func2() { return 0; }

    template<typename T>
    void Func3(T obj, int num) {}

    static void Func4() {}
};




//class A {
//protected:
//    int num = 0;
//    A() {
//        cout << "Parametrless A CTOR" << endl;
//    }
//
//public:
//    A(int num) : num(num) {
//        cout << "Parametrized A CTOR" << endl;
//    }
//
//    int GetNum() {
//        return this->num;
//    }
//};
//
//class B : public A {
//public:
//    B() : A(15) {
//        cout << "Parametrless B CTOR" << endl;
//    }
//
//    B(int num) : A(num) {
//        cout << "Parametrized B CTOR" << endl;
//    }
//};

// Animal
// Cat, Dog, Fish


class Hero {
protected:
    string name = "Unknown";
    int attack = 0;
    int defense = 0;
    bool isDistanceAttacking = false;

    Hero() {}
    Hero(string name) {}
    Hero(string name, int attack, int defense) : name(name), attack(attack), defense(defense) {}
};

class Archer : Hero {
protected:
    int arrowsCount = 0;

public:
    int GetArrowsCount() const {
        return this->arrowsCount;
    }
    int AddArrows(int count) {
        this->arrowsCount += abs(count);

        return this->GetArrowsCount();
    }

    Archer(string name, int attack, int defense) : Hero(name, attack, defense) {
        this->isDistanceAttacking = true;
    }
};

class Knight : Hero {
protected:
    int additionalDefense = 0;

public:
    Knight(string name, int attack, int defense, int additionalDefense = 0) 
        : Hero(name, attack, defense), 
        additionalDefense(additionalDefense) {
    }

    int GetAdditionalDefense() const {
        return this->additionalDefense;
    }
    int GetDefence() {
        return this->GetAdditionalDefense() + this->defense;
    }
    void SetAdditionalDefense(int additionalDefense) {
        this->additionalDefense = additionalDefense;
    }
};

int main() {
    Archer archer = Archer("Bob", 40, 5);
    cout << "Arrows count: " << archer.AddArrows(5) << endl;

    Knight knight = Knight("Beshir", 30, 40, 15);
    cout << "Defence: " << knight.GetDefence() << endl;



    /*B b1 = B();
    B b2 = B(15);

    cout << b1.GetNum() << endl;
    cout << b2.GetNum() << endl;*/




    //cout << sizeof(A) << endl;
    //cout << sizeof(B) << endl;

    //cout << sizeof(Temp) << endl;

    //A a = A();
    //PrintBytes(&a);
    


    //A a = A();
    //
    //cout << sizeof(A) << endl;
    //cout << sizeof(a) << endl;
}