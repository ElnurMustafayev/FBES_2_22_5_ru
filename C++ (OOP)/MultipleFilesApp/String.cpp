#include "String.h"
#include <cstring>

String::String(const char* str) {
	this->str = str;
}

int String::Length()
{
	return strlen(this->str);
}

const char* String::GetString()
{
	return this->str;
}
