#include <iostream>
#include <vector>

using namespace std;

template<typename T1, typename T2>
T2 Func2(T1 obj) {
	T1 num = 123;
	return num + obj;
}

template<typename qwerty>
int Func1(qwerty obj) {
	qwerty num = 123;
	return num + obj;
}


//template<typename T>
//class MyClass {
//public:
//	T first;
//	T second;
//	string third;
//
//	T Sum() {
//		return this->first + this->second;
//	}
//
//	template<typename T1, typename T2>
//	T Sum(T1 num1, T2 num2) {
//		cout << "T: " << sizeof(T) << endl;		// long long
//		cout << "T1: " << sizeof(T1) << endl;	// int
//		cout << "T2: " << sizeof(T2) << endl;	// int
//
//		return num1 + num2;
//	}
//};


//template<typename T>
//struct Item {
//	T value;
//};
//
//template<typename T>
//class Storage {
//public:
//	Item<T>* collection;
//};


template<typename T>
struct Person {
	T id;
	string name;
	string surname;
	int age;
}


template<typename T>
class Storage {
	int count = 0;
	T* collection = nullptr;

public:
	void AddElement(T newElement) {
		T* newArr = new T[this->count + 1];

		for (int i = 0; i < this->count; i++)
		{
			newArr[i] = this->collection[i];
		}

		newArr[this->count] = newElement;

		this->count++;

		delete[] this->collection;

		this->collection = newArr;
	}

	void Show() {
		for (int i = 0; i < this->count; i++)
		{
			cout << this->collection[i] << " ";
		}
		cout << endl;
	}
};

int main()
{
	vector<int> collection;

	collection.push_back(111);
	collection.push_back(222);
	collection.push_back(333);
	collection.push_back(444);
	collection.push_back(555);

	collection.pop_back();
	//cout << collection.at(2) << endl;
	//collection.clear();
	collection.resize(2);

	for (int i = 0; i < collection.size(); i++)
	{
		cout << collection.at(i) << endl;
	}




	/*Storage<double> storage;
	storage.AddElement(3);
	storage.AddElement(1);
	storage.AddElement(78);

	cout << storage.count << endl;
	storage.Show();*/









	//Item<Item<Item<int>>>* superItem = new Item<Item<Item<int>>>();
	


	/*Item<int>* item = new Item<int>();
	cout << item->value << endl;*/



	/*Storage<double> storage;
	storage.collection = new Item<double>();*/






	/*MyClass<long long> obj1;

	cout << obj1.Sum(123, 45) << endl;*/



	/*MyClass obj;
	obj.first = 'a';
	obj.second = 'q';

	cout << sizeof(obj) << endl;*/







	/*cout << Func1(27) << endl;
	cout << Func1('a') << endl;
	cout << Func1(12.5) << endl;

	cout << sizeof(Func1(27)) << endl;
	cout << sizeof(Func2<long long, long long>(27)) << endl;*/
}