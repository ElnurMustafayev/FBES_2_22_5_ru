#pragma once

#include <iostream>
using namespace std;

template<typename T>
class User {
	T id;
	string nickname;
	string password;

public:
	User(string nickname, string password);
	bool Login(string nickname, string password);

	string GetNickname() const;
};