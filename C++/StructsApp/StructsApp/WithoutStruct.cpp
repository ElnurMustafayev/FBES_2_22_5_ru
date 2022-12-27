#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;

enum GENDERS : int {
    male, female, other
};

const char* GetGenderStr(GENDERS gender) {
    switch (gender)
    {
    case male:
        return "male";
    case female:
        return "female";
    case other:
        return "other";
    default:
        return "unknown";
    }
}

void PrintUser(char* name, int age, GENDERS gender) {
    cout << "Name: " << name << endl;
    cout << "Age: " << age << endl;
    cout << "Gender: " << GetGenderStr(gender) << endl;
}

template<typename T>
T* AddElement(const T newEl, T* arr, int& length) {
    T* newAges = new T[length + 1] {};

    for (int i = 0; i < length; i++)
    {
        newAges[i] = arr[i];
    }

    newAges[length] = newEl;

    length++;

    delete[] arr;

    return newAges;
}

template<typename T>
T** AddElement(T* newEl, T** arr, int& length) {
    T** newAges = new T*[length + 1]{};

    for (int i = 0; i < length; i++)
    {
        newAges[i] = arr[i];
    }

    newAges[length] = newEl;

    length++;

    delete[] arr;

    return newAges;
}

char** AddName(char* name, char** names, int& length) {
    return AddElement(name, names, length);
}
int* AddAge(int age, int* ages, int& length) {
    return AddElement(age, ages, length);
}
GENDERS* AddGender(GENDERS gender, GENDERS* genders, int& length) {
    return AddElement(gender, genders, length);
}


void WithoutStruct()
{
    int namesLength = 0;
    int agesLength = 0;
    int gendersLength = 0;

    char** names = new char* [namesLength] { };
    int* ages = new int[agesLength]{ };
    GENDERS* genders = new GENDERS[gendersLength]{ };

    names = AddName((char*)"Bob", names, namesLength);
    ages = AddAge(33, ages, agesLength);
    genders = AddGender(GENDERS::male, genders, gendersLength);

    names = AddName((char*)"Ann", names, namesLength);
    ages = AddAge(27, ages, agesLength);
    genders = AddGender(GENDERS::female, genders, gendersLength);

    names = AddName((char*)"Ted", names, namesLength);
    ages = AddAge(12, ages, agesLength);
    genders = AddGender(GENDERS::other, genders, gendersLength);

    for (int i = 0; i < namesLength; i++)
    {
       PrintUser(names[i], ages[i], genders[i]);
       cout << endl;
    }
}