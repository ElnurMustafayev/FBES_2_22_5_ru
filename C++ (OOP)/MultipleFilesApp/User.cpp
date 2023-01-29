#include "User.h"


User::User(string nickname, string password) {
	this->nickname = nickname;
	this->password = password;
}

bool User::Login(string nickname, string password) {
	return this->nickname == nickname && this->password == password;
}

string User::GetNickname() const {
	return this->nickname;
}