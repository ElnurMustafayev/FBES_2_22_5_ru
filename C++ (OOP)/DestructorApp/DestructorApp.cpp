#include <iostream>

using namespace std;

struct MyStruct {
	MyStruct()
	{
		cout << "CTOR" << endl;
	}

	~MyStruct() {
		cout << "DTOR" << endl;
	}

	void Method() {
		cout << "METHOD" << endl;
	}
};

int main()
{
	cout << "PROGRAM START" << endl;
	{
		MyStruct* obj = new MyStruct();
		obj->Method();

		delete obj;
		obj->~MyStruct();
	}
	cout << "PROGRAM END" << endl;








	/*cout << "PROGRAM START" << endl;
	{
		MyStruct obj = MyStruct();
		obj.Method();
	}
	cout << "PROGRAM END" << endl;*/
}