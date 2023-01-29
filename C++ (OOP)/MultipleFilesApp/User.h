#pragma once

#include <iostream>
using namespace std;

class User {
	string nickname;
	string password;

public:
	User(string nickname, string password);
	bool Login(string nickname, string password);

	string GetNickname() const;
};