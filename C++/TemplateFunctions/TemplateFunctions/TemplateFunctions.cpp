#include <iostream>
#include "Calculator.h"

using namespace std;

int main()
{
	/*auto money = 0.;
	cin >> money;

	cout << MySum<double, double, double>(123.23, 'a') << endl;*/

	cout << SumOfTypes(123, 'a', 123.14235) << endl;
	cout << SumOfTypes<int, char, double>() << endl;

	/*PrintSum<int, int>(123, 45.56);
	PrintSum(123, 45.56);
	PrintSum<char, char>(123, 45.56);*/



	/*cout << MySum('q', 123) << endl;
	cout << MySum(123, 123) << endl;
	cout << MySum(123123123123123, 123123123123123) << endl;
	cout << MySum(123.34, '$') << endl;*/

	/*string str1 = "qwe";
	string str2 = "rty";

	cout << MySum(str1, str2) << endl;*/



	//Task1<int>();
	//Task1<char>();

	//char result = Task2<char>(97);
	//cout << sizeof((Task2<double>(97) + Task2<int>(100))) << endl;;



	/*cout << GetSize('a') << endl;
	cout << GetSize(true) << endl;
	cout << GetSize(145465) << endl;
	cout << GetSize(123.2f) << endl;
	cout << GetSize(12312313123123123) << endl;
	cout << GetSize(123.2) << endl;

	cout << "\n\n\n" << endl;

	cout << GetSize<char>() << endl;
	cout << GetSize<bool>() << endl;
	cout << GetSize<int>() << endl;
	cout << GetSize<float>() << endl;
	cout << GetSize<long long>() << endl;
	cout << GetSize<double>() << endl;*/



	/*Func(87);
	Func(87.5);
	Func('A');*/
	//Func("tqwetquwyet");

	/*Print(123);
	Print(123.234);
	Print(true);
	Print("sdasghdahsd");*/


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