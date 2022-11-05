#include <iostream>
#include "Calculator.h"

using namespace std;

template<typename T>
void Print(T param) {
	cout << param << endl;
}

int main()
{
	Print(123);
	Print(123.234);
	Print(true);
	Print("sdasghdahsd");


	//int result = Sum(123, 277);

	/*Sum(12312312, 12312312);
	Sum(123123.12312, 123123.12312);
	Sum("asdasd", "asdasd");*/

	/*PrintObjectSize(123);
	PrintObjectSize(123123123123123123);
	PrintObjectSize(123.124);
	PrintObjectSize(123.124f);
	PrintObjectSize("asdasdasd");*/
}