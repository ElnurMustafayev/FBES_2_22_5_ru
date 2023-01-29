#pragma once
class String
{
	const char* str;

public:
	String(const char* str);

	int Length();
	const char* GetString();
};