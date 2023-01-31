#include "User.h"

User<int>::User(string nickname, string password) {
	this->nickname = nickname;
	this->password = password;
}

bool User<int>::Login(string nickname, string password) {
	return this->nickname == nickname && this->password == password;
}

string User<int>::GetNickname() const {
	return this->nickname;
}